using Ambev.DeveloperEvaluation.Domain.Entities;
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
        
        CancellationInformation(request, storedSale);
        
        _mapper.Map(request, storedSale);
        storedSale.CalculateTotalAmount();
        

        var updatedSale = await _saleRepository.UpdateAsync(storedSale);

        var changedStatus = updatedSale.Active == true ? "Updated" : "Cancelled";
        _logger.LogInformation($"{changedStatus} sale id: {updatedSale.Id} with data: {updatedSale}", updatedSale);
        
        var result = _mapper.Map<UpdateSaleResult>(updatedSale);
        return result;
    }

    private void CancellationInformation(UpdateSaleCommand request, Sale storedSale)
    {
        var updatedInactiveIds = request.Items.Where(x => x.Id != Guid.Empty && !x.Active)
            .Select(x => x.Id).ToList();
        
        var storedItems = storedSale.Items.Where(x => x.Active).ToList();
        var cancellingItems = storedItems.Where(x => (!x.Active && updatedInactiveIds.Contains(x.Id))).ToList();
        
        if (cancellingItems.Count == 0) return;
        
        foreach(var cancellingItem in cancellingItems)
            _logger.LogInformation($"Cancelling sale item id:{cancellingItem.Id} with data {cancellingItem}", cancellingItem);
    }
}