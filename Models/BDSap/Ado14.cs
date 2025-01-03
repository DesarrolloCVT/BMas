using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ado14
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int ChildNum { get; set; }

    public string? ItemCode { get; set; }

    public string? WhsCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? OpenQty { get; set; }

    public string ObjectType { get; set; } = null!;

    public int LogInstanc { get; set; }

    public int? BaseChildN { get; set; }

    public string? EncryptIv { get; set; }
}
