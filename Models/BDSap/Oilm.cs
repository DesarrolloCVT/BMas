using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oilm
{
    public int MessageId { get; set; }

    public int? DocEntry { get; set; }

    public int? TransType { get; set; }

    public int? DocLineNum { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? EffectQty { get; set; }

    public short? LocType { get; set; }

    public string? LocCode { get; set; }

    public decimal? TotalLc { get; set; }

    public decimal? TotalFc { get; set; }

    public decimal? TotalSc { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseType { get; set; }

    public string? BaseCurr { get; set; }

    public string? Currency { get; set; }

    public int? AccumType { get; set; }

    public int? ActionType { get; set; }

    public decimal? ExpensesLc { get; set; }

    public decimal? ExpensesFc { get; set; }

    public decimal? ExpensesSc { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? ItemCode { get; set; }

    public string? BpcardCode { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? DocRate { get; set; }

    public string? Comment { get; set; }

    public string? JrnlMemo { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public int? BaseLine { get; set; }

    public int? SnBtype { get; set; }

    public short? CreateTime { get; set; }

    public string? DataSource { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public decimal? DocPrice { get; set; }

    public string? CardName { get; set; }

    public string? Dscription { get; set; }

    public string? TreeType { get; set; }

    public int? ApplObj { get; set; }

    public int? AppObjAbs { get; set; }

    public string? AppObjType { get; set; }

    public int? AppObjLine { get; set; }

    public string? BaseRef { get; set; }

    public int? TransSeqRf { get; set; }

    public int? LayerIdref { get; set; }

    public string? VersionNum { get; set; }

    public decimal? PriceRate { get; set; }

    public string? PriceCurr { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? Price { get; set; }

    public decimal? CishbQty { get; set; }

    public int? SubLineNum { get; set; }

    public string? PrjCode { get; set; }

    public int? SlpCode { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? UseDocPric { get; set; }

    public string? VendorNum { get; set; }

    public string? SerialNum { get; set; }

    public string? BlockNum { get; set; }

    public string? ImportLog { get; set; }

    public int? Location { get; set; }

    public decimal? DocPrcRate { get; set; }

    public string? DocPrcCurr { get; set; }

    public string? CgsOcrCod { get; set; }

    public string? CgsOcrCod2 { get; set; }

    public string? CgsOcrCod3 { get; set; }

    public string? CgsOcrCod4 { get; set; }

    public string? CgsOcrCod5 { get; set; }

    public int? BsubLineNo { get; set; }

    public int? AppSubLine { get; set; }

    public short? UserSign { get; set; }

    public decimal? SysRate { get; set; }

    public string? ExFromRpt { get; set; }

    public string? Ref3 { get; set; }

    public string? EnSetCost { get; set; }

    public decimal? RetCost { get; set; }

    public int? DocAction { get; set; }

    public string? UseShpdGd { get; set; }

    public decimal? AddTotalLc { get; set; }

    public decimal? AddExpLc { get; set; }

    public string? IsNegLnQty { get; set; }

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }
}
