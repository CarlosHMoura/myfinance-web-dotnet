using Microsoft.AspNetCore.Mvc;

namespace myfinance_web_dotnet.Controllers;

public class TransactionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
