using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Jdt1
{
    public int TransId { get; set; }

    public int LineId { get; set; }

    public string? Account { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Syscred { get; set; }

    public decimal? Sysdeb { get; set; }

    public decimal? Fcdebit { get; set; }

    public decimal? Fccredit { get; set; }

    public string? Fccurrency { get; set; }

    public DateTime? DueDate { get; set; }

    public int? SourceId { get; set; }

    public short? SourceLine { get; set; }

    public string? ShortName { get; set; }

    public int? IntrnMatch { get; set; }

    public int? ExtrMatch { get; set; }

    public string? ContraAct { get; set; }

    public string? LineMemo { get; set; }

    public string? Ref3Line { get; set; }

    public string? TransType { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? Ref2Date { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public int? CreatedBy { get; set; }

    public string? BaseRef { get; set; }

    public string? Project { get; set; }

    public string? TransCode { get; set; }

    public string? ProfitCode { get; set; }

    public DateTime? TaxDate { get; set; }

    public decimal? SystemRate { get; set; }

    public DateTime? MthDate { get; set; }

    public decimal? ToMthSum { get; set; }

    public short? UserSign { get; set; }

    public int? BatchNum { get; set; }

    public int? FinncPriod { get; set; }

    public int? RelTransId { get; set; }

    public int? RelLineId { get; set; }

    public string? RelType { get; set; }

    public int? LogInstanc { get; set; }

    public string? VatGroup { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? VatRate { get; set; }

    public string? Indicator { get; set; }

    public string? AdjTran { get; set; }

    public string? RevSource { get; set; }

    public string? ObjType { get; set; }

    public DateTime? VatDate { get; set; }

    public string? PaymentRef { get; set; }

    public decimal? SysbaseSum { get; set; }

    public int? MultMatch { get; set; }

    public string? VatLine { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? SysvatSum { get; set; }

    public string? Closed { get; set; }

    public decimal? GrossValue { get; set; }

    public int? CheckAbs { get; set; }

    public int? LineType { get; set; }

    public string? DebCred { get; set; }

    public int? SequenceNr { get; set; }

    public string? StornoAcc { get; set; }

    public decimal? BalDueDeb { get; set; }

    public decimal? BalDueCred { get; set; }

    public decimal? BalFcDeb { get; set; }

    public decimal? BalFcCred { get; set; }

    public decimal? BalScDeb { get; set; }

    public decimal? BalScCred { get; set; }

    public string? IsNet { get; set; }

    public string? DunWizBlck { get; set; }

    public int? DunnLevel { get; set; }

    public DateTime? DunDate { get; set; }

    public short? TaxType { get; set; }

    public string? TaxPostAcc { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public string? TaxCode { get; set; }

    public DateTime? ValidFrom { get; set; }

    public decimal? GrossValFc { get; set; }

    public DateTime? LvlUpdDate { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int? Mientry { get; set; }

    public int? Miventry { get; set; }

    public int? ClsInTp { get; set; }

    public int? CenVatCom { get; set; }

    public int? MatType { get; set; }

    public int? PstngType { get; set; }

    public DateTime? ValidFrom2 { get; set; }

    public DateTime? ValidFrom3 { get; set; }

    public DateTime? ValidFrom4 { get; set; }

    public DateTime? ValidFrom5 { get; set; }

    public int? Location { get; set; }

    public string? WtaxCode { get; set; }

    public decimal? EquVatRate { get; set; }

    public decimal? EquVatSum { get; set; }

    public decimal? SysequSum { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? Systvat { get; set; }

    public string? Wtliable { get; set; }

    public string? Wtline { get; set; }

    public decimal? Wtapplied { get; set; }

    public decimal? WtappliedS { get; set; }

    public decimal? WtappliedF { get; set; }

    public decimal? Wtsum { get; set; }

    public decimal? WtsumFc { get; set; }

    public decimal? WtsumSc { get; set; }

    public string? PayBlock { get; set; }

    public int? PayBlckRef { get; set; }

    public string? LicTradNum { get; set; }

    public int? InterimTyp { get; set; }

    public int? DprId { get; set; }

    public string? MatchRef { get; set; }

    public string? Ordered { get; set; }

    public int? Cup { get; set; }

    public int? Cig { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatRegNum { get; set; }

    public string? Sledgerf { get; set; }

    public string? InitRef2 { get; set; }

    public string? InitRef3Ln { get; set; }

    public string? ExpUuid { get; set; }

    public string? ExpOptype { get; set; }

    public int? ExTransId { get; set; }

    public short? DocArr { get; set; }

    public int? DocLine { get; set; }

    public string? Myftype { get; set; }

    public int? DocEntry { get; set; }

    public int? DocNum { get; set; }

    public string? DocType { get; set; }

    public string? DocSubType { get; set; }

    public int? RmrkTmpt { get; set; }

    public string? CemCode { get; set; }

    public int? InClassCat { get; set; }

    public int? InClassTyp { get; set; }

    public int? ExClassCat { get; set; }

    public int? ExClassTyp { get; set; }

    public int? VatclassCa { get; set; }

    public int? VatclassTy { get; set; }

    public int? EvatCate { get; set; }

    public int? EwtPercCat { get; set; }

    public decimal? EwtAmount { get; set; }

    public int? EbvatExCau { get; set; }

    public string? UExcluir { get; set; }

    public DateTime? UNewduedate { get; set; }

    public string? UComment { get; set; }
}
