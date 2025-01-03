using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz3
{
    public int IdEntry { get; set; }

    public int PymNum { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? PymMeth { get; set; }

    public string? GlaccCode { get; set; }

    public string? GlaccName { get; set; }

    public decimal? PymAmount { get; set; }

    public decimal? PymAmntFc { get; set; }

    public decimal? PymAmnSyst { get; set; }

    public int? InvKey { get; set; }

    public int? DocNum { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? ValDate { get; set; }

    public decimal? TotalLoc { get; set; }

    public decimal? TotalFc { get; set; }

    public decimal? TotalSys { get; set; }

    public decimal? DueBal { get; set; }

    public decimal? DueBalFc { get; set; }

    public decimal? DueBalSys { get; set; }

    public decimal? DiscPrcnt { get; set; }

    public decimal? DiscSum { get; set; }

    public decimal? DiscSumFc { get; set; }

    public decimal? DiscSumSy { get; set; }

    public decimal? PayAmount { get; set; }

    public decimal? PayAmntFc { get; set; }

    public decimal? PayAmntSys { get; set; }

    public decimal? InvPayAmnt { get; set; }

    public decimal? InvPayAmFc { get; set; }

    public decimal? InvPayAmSy { get; set; }

    public string? CardType { get; set; }

    public string? Country { get; set; }

    public string? ObjType { get; set; }

    public string? PymBnkTrns { get; set; }

    public string? ActFrmtCod { get; set; }

    public string? Checked { get; set; }

    public string? FatherLine { get; set; }

    public string? InvCurr { get; set; }

    public decimal? LineRate { get; set; }

    public decimal? BfDcntSum { get; set; }

    public decimal? BfNetDcnt { get; set; }

    public decimal? VatApplied { get; set; }

    public string? IsTax { get; set; }

    public string? IsFreight { get; set; }

    public string? IsOrigMeth { get; set; }

    public decimal? FreightSum { get; set; }

    public string? IsrRef { get; set; }

    public decimal? RoundSum { get; set; }

    public string? Agent { get; set; }

    public short? InstId { get; set; }

    public decimal? WtSum { get; set; }

    public int? BoeNum { get; set; }

    public string? NumAtCard { get; set; }

    public decimal? DeductPer { get; set; }

    public string? DpmPosted { get; set; }

    public string? Status { get; set; }

    public int? NumOfCheck { get; set; }

    public decimal? SumFrstChk { get; set; }

    public decimal? SumNxtChk { get; set; }

    public string? PayToCode { get; set; }

    public string? PayToCntr { get; set; }

    public string? PayToBank { get; set; }

    public string? PayToAct { get; set; }

    public string? PymCurr { get; set; }

    public decimal? TaxOnExpSu { get; set; }

    public int? TransId { get; set; }

    public string? OcrCode { get; set; }

    public int? LineId { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public DateTime? PymDate { get; set; }

    public decimal? BcgSum { get; set; }

    public decimal? BcgSumFc { get; set; }

    public decimal? BcgSumSy { get; set; }

    public decimal? BcgTaxSum { get; set; }

    public decimal? BcgTaxSumF { get; set; }

    public decimal? BcgTaxSumS { get; set; }

    public string? PrjCode { get; set; }

    public string? BcgVatGrp { get; set; }

    public string? LinePrjCod { get; set; }

    public decimal? BcgPmnt { get; set; }

    public decimal? BcgPmntFc { get; set; }

    public decimal? BcgPmntSc { get; set; }

    public int? PayOrderNo { get; set; }

    public string? LineType { get; set; }

    public int? ManualNum { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Ref3 { get; set; }

    public string? OrdrStatus { get; set; }

    public string? BnkCode { get; set; }

    public string? BnkAccNo { get; set; }

    public string? Branch { get; set; }

    public string? BnkCountr { get; set; }

    public string? TbankCode { get; set; }

    public string? TdflAccoun { get; set; }

    public string? TbankCount { get; set; }

    public string? TargetBran { get; set; }

    public DateTime? DscDueDate { get; set; }

    public int? Cig { get; set; }

    public int? Cup { get; set; }

    public string? BoeCurrSta { get; set; }

    public int? BoeKey { get; set; }

    public DateTime? BoeDate { get; set; }

    public DateTime? BoeDueDate { get; set; }

    public string? Instruct1 { get; set; }

    public string? Instruct2 { get; set; }

    public string? BoeCancIns { get; set; }

    public string? BoeOccCode { get; set; }

    public string? BoePtfId { get; set; }

    public int? BoeOurNum { get; set; }

    public decimal? BoeIntrAm { get; set; }

    public DateTime? BoeDiscD { get; set; }

    public decimal? BoeDisAmnt { get; set; }

    public DateTime? BoeFineD { get; set; }

    public decimal? BoeFineAmt { get; set; }

    public DateTime? BoeIntrstD { get; set; }

    public decimal? BoeIofamt { get; set; }

    public string? BoeMovCode { get; set; }

    public string? BarcodeRep { get; set; }

    public int? Bplid { get; set; }

    public int? Ponumber { get; set; }

    public int? Poseries { get; set; }

    public string? PaPriority { get; set; }

    public string? PaymType { get; set; }

    public string? OriPymMeth { get; set; }

    public string? PymMethTyp { get; set; }

    public string? SinglePym { get; set; }

    public string? MandateId { get; set; }

    public string? SeqType { get; set; }

    public DateTime? BaseDocDat { get; set; }

    public string? Okato { get; set; }

    public string? PostPeriod { get; set; }

    public string? RecipStatu { get; set; }

    public string? BudgetId { get; set; }

    public string? PymReason { get; set; }

    public string? BaseDocTyp { get; set; }

    public string? TaxPymType { get; set; }

    public string? Oktmo { get; set; }

    public string? PymIsUpdat { get; set; }

    public string? OriPymCode { get; set; }

    public string? OriPymType { get; set; }

    public int? ReasonCode { get; set; }

    public string? OriActCode { get; set; }

    public string? OriActName { get; set; }

    public int? ReasonLine { get; set; }

    public string? OriFormat { get; set; }

    public string? WtIsPym { get; set; }

    public string? Iban { get; set; }

    public string? SwiftNum { get; set; }

    public string? Uipcode { get; set; }

    public int? AgrNo { get; set; }

    public string? ExeByServ { get; set; }

    public string? SpltPmtVat { get; set; }

    public decimal? VatAmount { get; set; }

    public string? EnPayToAct { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }
}
