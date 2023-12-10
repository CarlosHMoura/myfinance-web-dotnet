using System.ComponentModel.DataAnnotations;

namespace myfinance_web_dotnet.Enumerations;

public enum TypeAccountEnum
{
    [Display(Name = "Despesa")]
    Expenses = 1,
    [Display(Name = "Receita")]
    Revenues = 2
}
