using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odun
{
    public int LineNum { get; set; }

    public string? LetrFormat { get; set; }

    public string? EffctAftr { get; set; }

    public decimal? LetterFee { get; set; }

    public string? FeeCurr { get; set; }

    public decimal? MinBalance { get; set; }

    public string? MinBlnCurr { get; set; }

    public string? CalcIntert { get; set; }
}
