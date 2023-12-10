using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Enumerations;

namespace myfinance_web_dotnet.Infrastructure;

public class MyFinanceDbContext : DbContext
{
    public MyFinanceDbContext()
    {
    }

    public MyFinanceDbContext(DbContextOptions<MyFinanceDbContext> options)
        : base(options)
    {
    }

    public DbSet<AccountPlanModel> AccountPlan { get; set; }
    public DbSet<TransactionModel> Transaction { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AccountPlanModel>(entity =>
        {

            entity.HasKey(p => p.Id);

            entity.Property(p => p.Description)
                .IsRequired();

            entity.Property(m => m.Type)
                .HasConversion(new EnumToNumberConverter<TypeAccountEnum, int>())
                .IsRequired();

        });


        modelBuilder.Entity<TransactionModel>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.History);

            entity.Property(p => p.Type);

            entity.Property(p => p.Value)
                .HasConversion<decimal>();

            entity.HasOne(p => p.AccountPlan)
                .WithMany(p => p.Transactions)
                .HasForeignKey(d => d.AccountPlanId);
        });
    }
}