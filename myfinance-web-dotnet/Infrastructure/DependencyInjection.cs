using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Interfaces;
using myfinance_web_dotnet.Services;
using System.Runtime.CompilerServices;

namespace myfinance_web_dotnet.Infrastructure;

public static class DependencyInjection
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        //DbContext EFCore Injection
        builder.Services.AddDbContext<MyFinanceDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));

        //AutoMapper Injection
        builder.Services.AddAutoMapper(AssemblyUtil.GetCurrentAssemblies());

        //Services Injection
        builder.Services.AddTransient<IAccountPlanService, AccountPlanService>();
        builder.Services.AddTransient<ITransactionService, TransactionService>();
    }
}
