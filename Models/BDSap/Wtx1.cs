using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtx1
{
    public int AbsEntry { get; set; }

    public int LineSeq { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public string? BaseObjTyp { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseArrTyp { get; set; }

    public int? BaseLinNum { get; set; }

    public int? BaseGrpNum { get; set; }

    public string? WtaxAbsId { get; set; }

    public string? Account { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Exemption { get; set; }

    public string? BaseType { get; set; }

    public decimal? BaseNetSum { get; set; }

    public decimal? BaseNetSc { get; set; }

    public decimal? BaseNetFc { get; set; }

    public decimal? BaseVatSum { get; set; }

    public decimal? BaseVatSc { get; set; }

    public decimal? BaseVatFc { get; set; }

    public decimal? AccBaseSum { get; set; }

    public decimal? AccBaseSc { get; set; }

    public decimal? AccBaseFc { get; set; }

    public decimal? AccWtaxSum { get; set; }

    public decimal? AccWtaxSc { get; set; }

    public decimal? AccWtaxFc { get; set; }

    public decimal? TxblSum { get; set; }

    public decimal? TxblSumSc { get; set; }

    public decimal? TxblSumFc { get; set; }

    public decimal? WtaxSum { get; set; }

    public decimal? WtaxSumSc { get; set; }

    public decimal? WtaxSumFc { get; set; }

    public decimal? ApplSum { get; set; }

    public decimal? ApplSumSc { get; set; }

    public decimal? ApplSumFc { get; set; }

    public string? CrditDebit { get; set; }

    public string? PostingTyp { get; set; }

    public string? Category { get; set; }

    public int? WttypeId { get; set; }

    public string? WhtType { get; set; }

    public int? FmlId { get; set; }

    public decimal? BaseMin { get; set; }

    public decimal? BaseMinSc { get; set; }

    public decimal? BaseMinFc { get; set; }

    public decimal? ResMin { get; set; }

    public decimal? ResMinSc { get; set; }

    public decimal? ResMinFc { get; set; }

    public decimal? AddBas { get; set; }

    public decimal? AddBasSc { get; set; }

    public decimal? AddBasFc { get; set; }

    public decimal? Abwvat { get; set; }

    public decimal? Abwvatsc { get; set; }

    public decimal? Abwvatfc { get; set; }
}
