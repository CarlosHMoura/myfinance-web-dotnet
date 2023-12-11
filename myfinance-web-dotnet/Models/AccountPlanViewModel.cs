using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_dotnet.Enumerations;

namespace myfinance_web_dotnet.Models;

public record AccountPlanViewModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public TypeAccountEnum Type { get; set; }
    public bool Active { get; set; }
    public List<SelectListItem> AllTypes
    {
        get
        {
            return Enum.GetValues(typeof(TypeAccountEnum))
                       .Cast<TypeAccountEnum>()
                       .Select(t => new SelectListItem
                       {
                           Value = t.ToString(),
                           Text = t.ToString()
                       })
                       .ToList();
        }
    }
}
