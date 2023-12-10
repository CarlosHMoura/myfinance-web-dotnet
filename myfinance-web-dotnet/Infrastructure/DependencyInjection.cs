using Microsoft.EntityFrameworkCore;

namespace myfinance_web_dotnet.Infrastructure;

public class DependencyInjection
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        //DbContext EFCore Injection
        services.AddDbContext<MyFinanceDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        //AutoMapper Injection
        services.AddAutoMapper(AssemblyUtil.GetCurrentAssemblies());

        //Services Injection
        services.AddTransient<IPlanoContaService, PlanoContaService>();
        services.AddTransient<ITransacaoService, TransacaoService>();
    }
}
