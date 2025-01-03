using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bgt3
{
    public int BudgId { get; set; }

    public string OcrCode { get; set; } = null!;

    public short DimCode { get; set; }

    public int? Instance { get; set; }

    public int LineId { get; set; }

    public decimal? DebLtotal { get; set; }

    public decimal? CredLtotal { get; set; }

    public decimal? DebStotal { get; set; }

    public decimal? CredStotal { get; set; }

    public short? UserSign { get; set; }
}
