# My Finance Web

This project is part of the Software Implementation and Evolution Practices course, which is part of the Postgraduate Program in Software Engineering at PUCMG.

## Description

My Finance Web is a comprehensive financial management platform designed to empower families in tracking their income and expenditures. Its primary goal is to facilitate a meticulous analysis of financial transactions, thereby enhancing overall financial planning. Users can create a customized Chart of Accounts to systematically categorize all transactions. Additionally, the platform provides essential features such as detailed expense reports, offering users a profound understanding of their financial landscape.

## Architecture

 ![docs](/MyFinanceWeb-ModelagemArquitetural.png)

## Used Packages

###  Front-End 
- Razor:
  - https://learn.microsoft.com/pt-br/aspnet/core/mvc/views/razor?view=aspnetcore-8.0

### Back-End
- AutoMapper:
  - https://www.nuget.org/packages/automapper
  - Versão: 12.0.1
- AutoMapper.Extensions.Microsoft.DependencyInjection:
  - https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection
  - Versão: 12.0.1
- Microsoft.EntityFrameworkCore
  - https://www.nuget.org/packages/Microsoft.EntityFrameworkCore
  - Versão: 8.0.0
- Microsoft.EntityFrameworkCore.SqlServer
  - https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer
  - Versão: 8.0.0
- Microsoft.EntityFrameworkCore.Design
  - https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design
  - Versão: 8.0.0
- Microsoft.EntityFrameworkCore.Tools
  - https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools
  - Versão: 8.0.0


## Requirements

- ASP.NET Core:
  - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
  - Versão: ^8.0

- Microsoft SQL Server
  - https://www.microsoft.com/pt-br/sql-server/

## Installation
   
1. Clone the Project Repository:

   ```
   git clone https://github.com/CarlosHMoura/myfinance-web-dotnet.git
   
   ```

2. Navigate to the Project Directory:

   ```
   cd myfinance-web-dotnet
   ```

3. Install Project Dependencies:

   ```
   dotnet restore
   ```
## How to Run

1. Run the Project:

   ```
   dotnet build
   dotnet run
   ```

2. Access the Application:

   ```
   http://localhost:5012
   ```