using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Interfaces;
using myfinance_web_dotnet.Models;
using System.Diagnostics;

namespace myfinance_web_dotnet.Controllers;

[Route("[controller]")]
public class AccountPlanController : Controller
{
    private readonly IAccountPlanService _accountPlanService;
    private readonly IMapper _mapper;

    public AccountPlanController(IAccountPlanService accountPlanService, IMapper mapper)
    {
        _accountPlanService = accountPlanService;
        _mapper = mapper;
    }

    [Route("Index")]
    public IActionResult Index()
    {
        return View(_mapper.Map<List<AccountPlanViewModel>>(_accountPlanService.ListAccountsPlan()));
    }

    [HttpGet]
    [Route("Register")]
    [Route("Register/{id}")]
    public IActionResult Register(int? id)
    {
        if (id != null)
        {
            return View(_mapper.Map<AccountPlanViewModel>(_accountPlanService.GetAccountPlan(id.Value)));
        }

        return View(new AccountPlanViewModel());
    }


    [HttpPost]
    [Route("Register")]
    [Route("Register/{id}")]
    public IActionResult Register(AccountPlanViewModel accountPlanViewModel)
    {
        _accountPlanService.Save(_mapper.Map<AccountPlanModel>(accountPlanViewModel));

        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("Delete/{id}")]
    public IActionResult Delete(int id)
    {
        _accountPlanService.Delete(id);

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
