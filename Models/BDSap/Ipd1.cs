using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ipd1
{
    public int DocEntry { get; set; }

    public int DocLineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? InvntryUom { get; set; }

    public decimal? OnHandBef { get; set; }

    public decimal? Price { get; set; }

    public decimal? Quantity { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string? IoffIncAcc { get; set; }

    public string? DoffDecAcc { get; set; }

    public string? OcrCode { get; set; }

    public string? WhsCode { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? DocTotalFc { get; set; }

    public decimal? DocTotalSy { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? ObjType { get; set; }

    public string? Project { get; set; }

    public string? BarCode { get; set; }

    public string? InvUoM { get; set; }

    public int? BinEntry { get; set; }

    public short? FirmCode { get; set; }

    public string? SuppCatNum { get; set; }

    public string? CardCode { get; set; }

    public DateTime? CountDate { get; set; }

    public int? CountTime { get; set; }

    public decimal? DiffPercnt { get; set; }

    public string? BaseRef { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public decimal? CountQty { get; set; }

    public string? Remark { get; set; }

    public int? LogInstanc { get; set; }

    public int? CpyCount { get; set; }

    public string? BinNegQty { get; set; }

    public int? VisOrder { get; set; }

    public int? UgpEntry { get; set; }

    public string? IuomEntry { get; set; }

    public string? UomCode { get; set; }

    public decimal? ItmsPerUnt { get; set; }

    public decimal? UomQty { get; set; }

    public decimal? ActPrice { get; set; }

    public decimal? PostValueL { get; set; }

    public decimal? PostValueS { get; set; }

    public string? UCausa { get; set; }

    public DateTime? UFechaVenc { get; set; }
}
