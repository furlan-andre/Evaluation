using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;


public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateSaleHandler> _logger;

    /// <summary>
    /// Initializes a new instance of UpdateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public UpdateSaleHandler(ISaleRepository saleRepository, IMapper mapper, ILogger<UpdateSaleHandler> logger)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Handles the UpdateSaleCommand request
    /// </summary>
    /// <param name="command">The UpdateSale command</param>
    /// <returns>The updated sale details</returns>
    public async Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateSaleCommandValidator();
        var validationResult = validator.Validate(request);
        
        if(!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var storedSale = await _saleRepository.GetByIdAsync(request.Id);
        if(storedSale is null)
            throw new KeyNotFoundException($"Sale with ID {request.Id} not found");
        
        _mapper.Map(request, storedSale);
        
        var updatedSale = await _saleRepository.UpdateAsync(storedSale);

        var changedStatus = updatedSale.Active == true ? "Updated" : "Cancelled";
        _logger.LogInformation($"{changedStatus} sale with data: {updatedSale}", updatedSale);
        
        var result = _mapper.Map<UpdateSaleResult>(updatedSale);
        return result;
    }
}