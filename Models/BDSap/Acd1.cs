using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acd1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? AcctCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? TotalSys { get; set; }

    public string? DprArea { get; set; }

    public string? Remarks { get; set; }

    public int? LogInstanc { get; set; }

    public string? NewItemCod { get; set; }

    public string? Partial { get; set; }

    public decimal? Apc { get; set; }

    public string? NewAstCls { get; set; }

    public string? ObjType { get; set; }

    public string? TransType { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? Project { get; set; }
}
