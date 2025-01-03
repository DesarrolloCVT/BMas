using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vpm2
{
    public int DocNum { get; set; }

    public int InvoiceId { get; set; }

    public int? DocEntry { get; set; }

    public decimal? SumApplied { get; set; }

    public decimal? AppliedFc { get; set; }

    public decimal? AppliedSys { get; set; }

    public string? InvType { get; set; }

    public decimal? DocRate { get; set; }

    public int? Flags { get; set; }

    public string? IntrsStat { get; set; }

    public int? DocLine { get; set; }

    public decimal? VatApplied { get; set; }

    public decimal? VatAppldFc { get; set; }

    public decimal? VatAppldSy { get; set; }

    public string? SelfInv { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public decimal? Dcount { get; set; }

    public decimal? DcntSum { get; set; }

    public decimal? DcntSumFc { get; set; }

    public decimal? DcntSumSy { get; set; }

    public decimal? BfDcntSum { get; set; }

    public decimal? BfDcntSumF { get; set; }

    public decimal? BfDcntSumS { get; set; }

    public decimal? BfNetDcnt { get; set; }

    public decimal? BfNetDcntF { get; set; }

    public decimal? BfNetDcntS { get; set; }

    public decimal? PaidSum { get; set; }

    public decimal? ExpAppld { get; set; }

    public decimal? ExpAppldFc { get; set; }

    public decimal? ExpAppldSc { get; set; }

    public decimal? Rounddiff { get; set; }

    public decimal? RounddifFc { get; set; }

    public decimal? RounddifSc { get; set; }

    public short? InstId { get; set; }

    public decimal? WtAppld { get; set; }

    public decimal? WtAppldFc { get; set; }

    public decimal? WtAppldSc { get; set; }

    public DateTime? LinkDate { get; set; }

    public DateTime? AmtDifPst { get; set; }

    public string? PaidDpm { get; set; }

    public string? DpmPosted { get; set; }

    public decimal? ExpVatSum { get; set; }

    public decimal? ExpVatSumF { get; set; }

    public decimal? ExpVatSumS { get; set; }

    public string? IsRateDiff { get; set; }

    public decimal? WtInvCatS { get; set; }

    public decimal? WtInvCatSf { get; set; }

    public decimal? WtInvCatSs { get; set; }

    public string? OcrCode { get; set; }

    public int? DocTransId { get; set; }

    public int? Mientry { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? IsSelected { get; set; }

    public decimal? WtonHold { get; set; }

    public decimal? WtonhldPst { get; set; }

    public int? BaseAbs { get; set; }

    public string? Mitype { get; set; }

    public string? DocSubType { get; set; }

    public string? SpltPmtVat { get; set; }

    public string? EncryptIv { get; set; }

    public int? UTipoDocRel { get; set; }

    public int? UFolioDocRel { get; set; }

    public string? UNoDi { get; set; }

    public string? USnRelacionado { get; set; }
}
