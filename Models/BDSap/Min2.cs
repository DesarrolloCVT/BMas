using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Min2
{
    public int? MinvNum { get; set; }

    public int? DocNum { get; set; }

    public string DocType { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public decimal? ItemPrice { get; set; }

    public string? ItemCurr { get; set; }

    public decimal? ItemRate { get; set; }

    public decimal? ItemQuan { get; set; }

    public string? ItemType { get; set; }

    public decimal? ItemTotal { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? LineTotal { get; set; }

    public int Entry { get; set; }

    public int AbsEntry { get; set; }
}
