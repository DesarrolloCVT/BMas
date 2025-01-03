using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1AllDocumentsView
{
    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public int? DocNum { get; set; }

    public string? LicTradNum { get; set; }

    public string? NumAtCard { get; set; }

    public int? Series { get; set; }

    public string? DocCur { get; set; }

    public decimal? DocRate { get; set; }

    public int? FinncPriod { get; set; }

    public string? Address { get; set; }

    public string? Canceled { get; set; }

    public string? JrnlMemo { get; set; }

    public int DocEntry { get; set; }

    public string? ObjType { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? Indicator { get; set; }

    public string? InsurOp347 { get; set; }

    public string? ResidenNum { get; set; }

    public string? PayToCode { get; set; }

    public string? IsIct { get; set; }

    public string? Address2 { get; set; }

    public int? Cig { get; set; }

    public int? Cup { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? Model { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public string IsDraft { get; set; } = null!;

    public string? EdocGenTyp { get; set; }

    public int? Bplid { get; set; }

    public int? FolNumFrom { get; set; }

    public int? FolNumTo { get; set; }

    public string? DocStatus { get; set; }

    public string? SplitPmnt { get; set; }

    public string? Comments { get; set; }

    public DateTime? DocDueDate { get; set; }
}
