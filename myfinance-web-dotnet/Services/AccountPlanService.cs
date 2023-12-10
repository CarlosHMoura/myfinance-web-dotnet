using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Interfaces;

namespace myfinance_web_dotnet.Services;

public class AccountPlanService : IAccountPlanService
{
    private readonly MyFinanceDbContext _financeDbContext;
    public AccountPlanService(MyFinanceDbContext financeDbContext)
    {
        _financeDbContext = financeDbContext;
    }
    public void Delete(int id)
    {
        var item = this.GetAccountPlan(id);

        if (item != null)
        {
            item.Active = false;
            _financeDbContext.SaveChanges();
        }
    }

    public AccountPlanModel? GetAccountPlan(int id)
    {
        return _financeDbContext.AccountPlan.FirstOrDefault(p => p.Id == id);
    }

    public IList<AccountPlanModel> ListAccountsPlan()
    {
        return _financeDbContext.AccountPlan.Where(p => p.Active == true).ToList();
    }

    public void Save(AccountPlanModel model)
    {
        if (model.Id == 0)
        {
            model.Active = true;
            _financeDbContext.AccountPlan.Add(model);
        }
        else
        {
            _financeDbContext.AccountPlan.Attach(model);
            _financeDbContext.Entry(model).State = EntityState.Modified;
        }
        _financeDbContext.SaveChanges();
    }
}
