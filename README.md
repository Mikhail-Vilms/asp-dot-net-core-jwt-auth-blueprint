# Template with functionality related to JWT authentication process for ASP.NET Core app

##Summary


## Prequisites

- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)

- [Postgres](https://www.postgresql.org/)

- [Entity Framework Core Tools for the .NET Command-Line Interface](https://www.nuget.org/packages/dotnet-ef/)
     >dotnet tool install --global dotnet-ef --version 3.0.0-preview8.19405.11


## Installation

1) Clone repository via command:
     >git clone https://github.com/Mikhail-Vilms/asp-dot-net-core-jwt-auth-blueprint.git
	 
2) Execute command from repository root folder:
     >dotnet clean
	 >dotnet build

3) Execute command from repository root folder:
     >dotnet ef migrations add InitialCreate

4) Verify that new folder has been created with the next title: "Migrations"

5) Assign appropriate value for database connection string in "appsettings.json" file

6) Execute command from repository root folder:
   >dotnet ef database update InitialCreate

## Packages used

- We need "Microsoft.EntityFrameworkCore.Design" package in order to be able to execute next command: "dotnet ef migrations add InitialCreate";
