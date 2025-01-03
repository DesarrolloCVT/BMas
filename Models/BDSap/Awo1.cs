using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awo1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? BaseQty { get; set; }

    public decimal? PlannedQty { get; set; }

    public decimal? IssuedQty { get; set; }

    public string? IssueType { get; set; }

    public string? WareHouse { get; set; }

    public int VisOrder { get; set; }

    public string? WipActCode { get; set; }

    public decimal? CompTotal { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int? LocCode { get; set; }

    public int LogInstanc { get; set; }

    public string? Project { get; set; }

    public int? UomEntry { get; set; }

    public string? UomCode { get; set; }

    public int? ItemType { get; set; }

    public decimal? AdditQty { get; set; }

    public string? LineText { get; set; }

    public string? PickStatus { get; set; }

    public decimal? PickQty { get; set; }

    public int? PickIdNo { get; set; }

    public decimal? ReleaseQty { get; set; }

    public string? ResAlloc { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? StageId { get; set; }

    public decimal? BaseQtyNum { get; set; }

    public decimal? BaseQtyDen { get; set; }

    public decimal? ReqDays { get; set; }

    public decimal? RtCalcProp { get; set; }

    public string? Status { get; set; }

    public string? ItemName { get; set; }

    public string? AlwProcDoc { get; set; }

    public int? PoDocType { get; set; }

    public int? PoDocNum { get; set; }

    public int? PoDocEntry { get; set; }

    public int? PoLineNum { get; set; }

    public decimal? PoQuantity { get; set; }

    public string? UCostoArticulo { get; set; }
}
