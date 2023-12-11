using AutoMapper;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Models;

namespace myfinance_web_dotnet.Mappers;

public class TransactionMap : Profile
{
    public TransactionMap()
    {
        CreateMap<TransactionModel, TransactionViewModel>().ReverseMap();
    }
}
