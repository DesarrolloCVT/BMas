using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ain1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public string? Freeze { get; set; }

    public string? WhsCode { get; set; }

    public decimal? InWhsQty { get; set; }

    public string? Counted { get; set; }

    public decimal? CountQty { get; set; }

    public decimal? CountQtyT1 { get; set; }

    public decimal? CountQtyT2 { get; set; }

    public string? Remark { get; set; }

    public string? BarCode { get; set; }

    public string? InvUoM { get; set; }

    public decimal? Difference { get; set; }

    public decimal? DiffPercen { get; set; }

    public DateTime? CountDate { get; set; }

    public int? CountTime { get; set; }

    public string? TargetRef { get; set; }

    public int? TargetType { get; set; }

    public int? TargetEntr { get; set; }

    public int? TargetLine { get; set; }

    public string? ProjCode { get; set; }

    public string? OcrCode { get; set; }

    public string? LineStatus { get; set; }

    public int? BinEntry { get; set; }

    public int? VisOrder { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public short? FirmCode { get; set; }

    public string? SuppCatNum { get; set; }

    public string? PrefVendor { get; set; }

    public int LogIns { get; set; }

    public int? UgpEntry { get; set; }

    public string? IuomEntry { get; set; }

    public decimal? CountDiff { get; set; }

    public decimal? CountDiffP { get; set; }

    public string? UomCode { get; set; }

    public decimal? UomQty { get; set; }

    public string? UCausa { get; set; }

    public DateTime? UFechaVenc { get; set; }
}
