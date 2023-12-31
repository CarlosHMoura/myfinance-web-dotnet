﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_dotnet.Models;

public record TransactionViewModel
{
    public int Id { get; set; }
    public string? History { get; set; }
    public string? Type { get; set; }
    public decimal? Value { get; set; }
    public DateTime Date { get; set; }
    public int AccountPlanId { get; set; }
    public bool? Active { get; set; }
    public List<AccountPlanViewModel> AccountsPlan { get; set; } = new List<AccountPlanViewModel>();

    public List<SelectListItem> TypesAccountPlan
    {
        get
        {
            return AccountsPlan
                        .Select(t => new SelectListItem
                        {
                            Value = t.Id.ToString(),
                            Text = t.Description
                        })
                        .ToList();

        }

    }
}
