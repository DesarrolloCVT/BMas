using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oamd
{
    public int LineNum { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? CardCode { get; set; }

    public string? Approved { get; set; }

    public decimal? AmountDiff { get; set; }

    public decimal? TaxAmtDiff { get; set; }

    public string? RpCurrency { get; set; }

    public string? VendOffAct { get; set; }
}
