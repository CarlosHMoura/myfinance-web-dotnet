using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Interfaces;

public interface ITransactionService
{
    IList<TransactionModel> ListTransactions();
    void Save(TransactionModel model);
    TransactionModel? GetTransaction(int id);
    void Delete(int id);
}
