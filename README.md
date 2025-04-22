## This project was made for developer evaluation

- Using dotnet core 8 
- Using postgresSQL database
- Using CQRS design pattern 
- Using DDD. 
- Using Clean Code. 
- Using MediatR
- Using xUnit
- Using EntityFrameworkCore


## This project have a Living documentation
- Using OpenApi (Swagger) to visualize the documentation and playground yourself in the project.
- Index page for Swagger: http://localhost:5119/swagger/index.html


## Running specifications
- This project is a MVP for Sales feature.
- Running in http schema an by default on http://localhost:5119
- checkout for appsettings.json file in WebApi (startup) project if you want to change the database secrets (default by me: Id=postgres;Password=pw)
- Its configured to run migrations when run in develop mode (Debug).
- To run the applications: set the WebApi project by the default project to run and run as debug.