using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vrt2
{
    public string TxInvRptNo { get; set; } = null!;

    public int GridRow { get; set; }

    public int? Bplid { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public DateTime? DocDate { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemDes { get; set; }

    public string? TaxCode { get; set; }

    public decimal? ItemQty { get; set; }

    public decimal? ItemPrice { get; set; }

    public decimal? BaseAmt { get; set; }

    public decimal? TaxAmt { get; set; }

    public int? LineType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocType { get; set; }

    public int? LineNum { get; set; }

    public string? Currency { get; set; }

    public string? Remark { get; set; }

    public string? LegacyData { get; set; }

    public decimal? Quantity { get; set; }
}
