﻿using System.ComponentModel.DataAnnotations;

namespace myfinance_web_dotnet.Enumerations;

public enum TypeAccountEnum
{
    [Display(Name = "Despesa")]
    Despesa = 1,
    [Display(Name = "Receita")]
    Receita = 2
}
