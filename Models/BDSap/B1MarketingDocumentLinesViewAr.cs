using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1MarketingDocumentLinesViewAr
{
    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? LineStatus { get; set; }

    public string? AcctCode { get; set; }

    public string? Ceecflag { get; set; }

    public string? TaxRelev { get; set; }

    public string? TaxOnly { get; set; }

    public string? ItemCode { get; set; }

    public string? ShipFromCo { get; set; }

    public string? ShipToCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? UomCode { get; set; }

    public decimal? Weight1 { get; set; }

    public short? Wght1Unit { get; set; }

    public decimal? LineTotal { get; set; }

    public string? WhsCode { get; set; }

    public int? VisOrder { get; set; }
}
