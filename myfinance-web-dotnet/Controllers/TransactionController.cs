using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Interfaces;
using myfinance_web_dotnet.Models;
using System.Diagnostics;

namespace myfinance_web_dotnet.Controllers;

[Route("[controller]")]
public class TransactionController : Controller
{
    private readonly ITransactionService _transactionService;
    private readonly IAccountPlanService _accountPlanService;
    private readonly IMapper _mapper;

    public TransactionController(ITransactionService transactionService, IMapper mapper, IAccountPlanService accountPlanService)
    {
        _transactionService = transactionService;
        _mapper = mapper;
        _accountPlanService = accountPlanService;
    }
    [Route("Index")]
    public IActionResult Index()
    {
        return View(_mapper.Map<List<TransactionViewModel>>(_transactionService.ListTransactions()));
    }

    [HttpGet]
    [Route("Register")]
    [Route("Register/{id}")]
    public IActionResult Register(int? id)
    {
        if (id != null)
        {
            var model = new TransactionViewModel();

            model = _mapper.Map<TransactionViewModel>(_transactionService.GetTransaction(id.Value));
            model.AccountsPlan = _mapper.Map<List<AccountPlanViewModel>>(_accountPlanService.ListAccountsPlan());

            return View(model);
        }

        return View(new TransactionViewModel { AccountsPlan = _mapper.Map<List<AccountPlanViewModel>>(_accountPlanService.ListAccountsPlan()) });
    }


    [HttpPost]
    [Route("Register")]
    [Route("Register/{id}")]
    public IActionResult Register(TransactionViewModel model)
    {
        _transactionService.Save(_mapper.Map<TransactionModel>(model));

        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("Delete/{id}")]
    public IActionResult Delete(int id)
    {
        _transactionService.Delete(id);

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
