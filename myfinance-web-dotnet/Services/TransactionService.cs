using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Interfaces;

namespace myfinance_web_dotnet.Services;

public class TransactionService : ITransactionService
{
    private readonly MyFinanceDbContext _financeDbContext;
    public TransactionService(MyFinanceDbContext financeDbContext)
    {
        _financeDbContext = financeDbContext;
    }
    public void Delete(int id)
    {
        var item = this.GetTransaction(id);

        if (item != null)
        {
            item.Active = false;
            _financeDbContext.SaveChanges();
        }
    }

    public TransactionModel? GetTransaction(int id)
    {
        return _financeDbContext.Transaction.FirstOrDefault(p => p.Id == id);
    }

    public IList<TransactionModel> ListTransactions()
    {
        return _financeDbContext.Transaction.Where(p => p.Active == true).ToList();
    }

    public void Save(TransactionModel model)
    {
        if (model.Id == 0)
        {
            model.Date = DateTime.Now;
            model.Active = true;
            _financeDbContext.Transaction.Add(model);
        }
        else
        {
            _financeDbContext.Transaction.Attach(model);
            _financeDbContext.Entry(model).State = EntityState.Modified;
        }

        _financeDbContext.SaveChanges();
    }
}
