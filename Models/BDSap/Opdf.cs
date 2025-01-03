using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opdf
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public string? DocType { get; set; }

    public string? Canceled { get; set; }

    public string? Handwrtten { get; set; }

    public string? Printed { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? Address { get; set; }

    public decimal? DdctPrcnt { get; set; }

    public decimal? DdctSum { get; set; }

    public decimal? DdctSumFc { get; set; }

    public string? CashAcct { get; set; }

    public decimal? CashSum { get; set; }

    public decimal? CashSumFc { get; set; }

    public decimal? CreditSum { get; set; }

    public decimal? CredSumFc { get; set; }

    public string? CheckAcct { get; set; }

    public decimal? CheckSum { get; set; }

    public decimal? CheckSumFc { get; set; }

    public string? TrsfrAcct { get; set; }

    public decimal? TrsfrSum { get; set; }

    public decimal? TrsfrSumFc { get; set; }

    public DateTime? TrsfrDate { get; set; }

    public string? TrsfrRef { get; set; }

    public string? PayNoDoc { get; set; }

    public decimal? NoDocSum { get; set; }

    public decimal? NoDocSumFc { get; set; }

    public string? DocCurr { get; set; }

    public string? DiffCurr { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? SysRate { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? DocTotalFc { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? CounterRef { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public int? TransId { get; set; }

    public short? DocTime { get; set; }

    public string? ShowAtCard { get; set; }

    public string? SpiltTrans { get; set; }

    public string? CreateTran { get; set; }

    public int? Flags { get; set; }

    public int? CntctCode { get; set; }

    public decimal? DdctSumSy { get; set; }

    public decimal? CashSumSy { get; set; }

    public decimal? CredSumSy { get; set; }

    public decimal? CheckSumSy { get; set; }

    public decimal? TrsfrSumSy { get; set; }

    public decimal? NoDocSumSy { get; set; }

    public decimal? DocTotalSy { get; set; }

    public string? ObjType { get; set; }

    public decimal? StornoRate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ApplyVat { get; set; }

    public DateTime? TaxDate { get; set; }

    public int? Series { get; set; }

    public string? Confirmed { get; set; }

    public string? ShowJdt { get; set; }

    public string? BankCode { get; set; }

    public string? BankAcct { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? VatSumSy { get; set; }

    public int? FinncPriod { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? Dcount { get; set; }

    public decimal? DcntSum { get; set; }

    public decimal? DcntSumFc { get; set; }

    public decimal? DcntSumSy { get; set; }

    public string? SpltCredLn { get; set; }

    public string? PrjCode { get; set; }

    public string? PaymentRef { get; set; }

    public string? Submitted { get; set; }

    public string? Status { get; set; }

    public string? PayMth { get; set; }

    public string? BankCountr { get; set; }

    public decimal? FreightSum { get; set; }

    public decimal? FreigtFc { get; set; }

    public decimal? FreigtSc { get; set; }

    public string? BoeAcc { get; set; }

    public int? BoeNum { get; set; }

    public decimal? BoeSum { get; set; }

    public decimal? BoeSumFc { get; set; }

    public decimal? BoeSumSc { get; set; }

    public string? BoeAgent { get; set; }

    public string? BoeStatus { get; set; }

    public string? WtCode { get; set; }

    public decimal? WtSum { get; set; }

    public decimal? WtSumFrgn { get; set; }

    public decimal? WtSumSys { get; set; }

    public string? WtAccount { get; set; }

    public decimal? WtBaseAmnt { get; set; }

    public string? Proforma { get; set; }

    public int? BoeAbs { get; set; }

    public string? BpAct { get; set; }

    public decimal? BcgSum { get; set; }

    public decimal? BcgSumFc { get; set; }

    public decimal? BcgSumSy { get; set; }

    public string? Pindicator { get; set; }

    public string? PaPriority { get; set; }

    public string? PayToCode { get; set; }

    public string? IsPaytoBnk { get; set; }

    public string? PbnkCnt { get; set; }

    public string? PbnkCode { get; set; }

    public string? PbnkAccnt { get; set; }

    public string? PbnkBranch { get; set; }

    public string? WizDunBlck { get; set; }

    public decimal? WtBaseSum { get; set; }

    public decimal? WtBaseSumF { get; set; }

    public decimal? WtBaseSumS { get; set; }

    public decimal? UndOvDiff { get; set; }

    public decimal? UndOvDiffS { get; set; }

    public int? BankActKey { get; set; }

    public string? VersionNum { get; set; }

    public DateTime? VatDate { get; set; }

    public string? TransCode { get; set; }

    public string? PaymType { get; set; }

    public decimal? TfrRealAmt { get; set; }

    public DateTime? CancelDate { get; set; }

    public decimal? OpenBal { get; set; }

    public decimal? OpenBalFc { get; set; }

    public decimal? OpenBalSc { get; set; }

    public decimal? BcgTaxSum { get; set; }

    public decimal? BcgTaxSumF { get; set; }

    public decimal? BcgTaxSumS { get; set; }

    public int? TpwId { get; set; }

    public string? ChallanNo { get; set; }

    public string? ChallanBak { get; set; }

    public DateTime? ChallanDat { get; set; }

    public string? WddStatus { get; set; }

    public string? BcgVatGrp { get; set; }

    public decimal? BcgVatPcnt { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public string? Bsrcode { get; set; }

    public int? LocCode { get; set; }

    public decimal? WtonhldPst { get; set; }

    public short? UserSign2 { get; set; }

    public string? BuildDesc { get; set; }

    public string? ResidenNum { get; set; }

    public string? OperatCode { get; set; }

    public decimal? UndOvDiffF { get; set; }

    public int? Mientry { get; set; }

    public string? FreeText1 { get; set; }

    public string? FreeText2 { get; set; }

    public string? FreeText3 { get; set; }

    public string? ShowDocNo { get; set; }

    public decimal? Tdsinterst { get; set; }

    public decimal? Tdscharges { get; set; }

    public int? Cup { get; set; }

    public int? Cig { get; set; }

    public string? Mitype { get; set; }

    public string? SupplCode { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatregNum { get; set; }

    public string? BplcentPmt { get; set; }

    public int? DraftKey { get; set; }

    public decimal? Tdsfee { get; set; }

    public int? MinHeadCl { get; set; }

    public DateTime? Sepadate { get; set; }

    public int? OwnerCode { get; set; }

    public int? AgrNo { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public string? Tdstype { get; set; }

    public string? DrNo { get; set; }

    public string? PmntWtcert { get; set; }

    public string? EnPbnkAcct { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }

    public string? PriceMode { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public string? EnblDpmTax { get; set; }

    public string? SignMsg { get; set; }

    public string? SignDigest { get; set; }

    public string? CertifNum { get; set; }

    public int? KeyVersion { get; set; }

    public string? QrcodeSpgn { get; set; }

    public int? DataVers { get; set; }

    public string? UExcluir { get; set; }

    public int? UTipoDocRel { get; set; }

    public int? UFolioDocRel { get; set; }

    public string? UNoDi { get; set; }

    public string? UIdtienda { get; set; }

    public string? UIdcaja { get; set; }

    public string? UIdtrans { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public decimal? UX4rCashpaid { get; set; }

    public decimal? UX4rCashchange { get; set; }

    public string? UIdcajaHisto { get; set; }

    public string? UX4rCodigo { get; set; }

    public int? UX4rLinea { get; set; }

    public decimal? UX4rValordisct { get; set; }
}
