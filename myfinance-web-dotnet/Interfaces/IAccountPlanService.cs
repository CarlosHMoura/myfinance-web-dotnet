using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Interfaces;

public interface IAccountPlanService
{
    IList<AccountPlanModel> ListAccountsPlan();
    void Save(AccountPlanModel model);
    AccountPlanModel? GetAccountPlan(int id);
    void Delete(int id);
}
