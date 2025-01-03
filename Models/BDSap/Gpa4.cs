using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa4
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? LineType { get; set; }

    public decimal? CurrCogs { get; set; }

    public decimal? CalcCogs { get; set; }

    public decimal? CogsDebit { get; set; }

    public decimal? CogsCredit { get; set; }

    public string? CogsAcct { get; set; }

    public string? PrDiffAcct { get; set; }

    public string? AutoPost { get; set; }
}
