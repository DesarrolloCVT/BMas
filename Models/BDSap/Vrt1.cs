using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vrt1
{
    public string TxInvRptNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public DateTime? Md { get; set; }

    public string? ItemDesc { get; set; }

    public string? Unit { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? BaseAmt { get; set; }

    public decimal? TaxAmt { get; set; }

    public string? Remark { get; set; }
}
