using AutoMapper;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Models;

namespace myfinance_web_dotnet.Mappers
{
    public class AccountPlanMap: Profile
    {
        public AccountPlanMap()
        {
            CreateMap<AccountPlanModel, AccountPlanViewModel>().ReverseMap();
        }
    }
}
