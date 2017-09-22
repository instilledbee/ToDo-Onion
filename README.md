# ToDo-Onion
Todo microservice using onion architecture

## Project Layout

The `Todo.Core` namespace encapsulates the core business rules for the Todo service.

* `Todo.Core.Models` contains the business model [POCOs](https://en.wikipedia.org/wiki/Plain_Old_CLR_Object).
* `Todo.Core.Interfaces` defines interfaces to be implemented by business logic classes
* `Todo.Core.Business` includes implementations of business logic as defined by the interfaces. This includes data validation, business processes, etc.

The `Todo.Repository` namespace contains data access logic. It is dependent on the `Core.Models` namespace, as well as the [Dapper](https://github.com/StackExchange/Dapper) ORM library.

The `Todo.Service` namespace contains the service endpoint scaffolding. It is dependent on the `Core` namespace and the repository for data access. The service uses [NancyFx](https://github.com/NancyFx/Nancy) as a microservice framework and IoC functionality.

## Running the project

Run `dotnet restore` and `dotnet run` on the root of the project folder, which contains the solution file. The service will run on http://localhost:5000

