using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Amr1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? LineTotal { get; set; }

    public string? WhsCode { get; set; }

    public string? RincmAcct { get; set; }

    public string? RdcrmAcct { get; set; }

    public decimal? RtoStock { get; set; }

    public decimal? RactPrice { get; set; }

    public decimal? RonHand { get; set; }

    public int LogInstanc { get; set; }

    public string ObjType { get; set; } = null!;

    public string? EvalSystem { get; set; }

    public string? OcrCode { get; set; }

    public string? UnitMsr { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? Project { get; set; }
}
