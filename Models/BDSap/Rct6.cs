using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rct6
{
    public int DocNum { get; set; }

    public int? InvoiceId { get; set; }

    public string? Wtcode { get; set; }

    public string? PymMean { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Wtsum { get; set; }

    public decimal? WtsumFc { get; set; }

    public decimal? WtsumSc { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TaxbleAmnt { get; set; }

    public decimal? TxblAmntFc { get; set; }

    public decimal? TxblAmntSc { get; set; }

    public decimal? PymAmount { get; set; }

    public decimal? PymAmounF { get; set; }

    public decimal? PymAmounS { get; set; }

    public int Line { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public decimal? TdsBamt { get; set; }

    public decimal? TdsBamtSc { get; set; }

    public decimal? TdsBamtFc { get; set; }

    public decimal? SurBamt { get; set; }

    public decimal? SurBamtSc { get; set; }

    public decimal? SurBamtFc { get; set; }

    public decimal? CessBamt { get; set; }

    public decimal? CessBamtSc { get; set; }

    public decimal? CessBamtFc { get; set; }

    public decimal? HscBamt { get; set; }

    public decimal? HscBamtSc { get; set; }

    public decimal? HscBamtFc { get; set; }

    public decimal? TdsAmnt { get; set; }

    public decimal? TdsAmntSc { get; set; }

    public decimal? TdsAmntFc { get; set; }

    public decimal? SurAmnt { get; set; }

    public decimal? SurAmntSc { get; set; }

    public decimal? SurAmntFc { get; set; }

    public decimal? CessAmnt { get; set; }

    public decimal? CessAmntSc { get; set; }

    public decimal? CessAmntFc { get; set; }

    public decimal? HscAmnt { get; set; }

    public decimal? HscAmntSc { get; set; }

    public decimal? HscAmntFc { get; set; }

    public int? WttypeId { get; set; }

    public decimal? Wtposted { get; set; }

    public decimal? WtpostedFc { get; set; }

    public decimal? WtpostedSc { get; set; }

    public decimal? IgstBamt { get; set; }

    public decimal? IgstBamtSc { get; set; }

    public decimal? IgstBamtFc { get; set; }

    public decimal? CgstBamt { get; set; }

    public decimal? CgstBamtSc { get; set; }

    public decimal? CgstBamtFc { get; set; }

    public decimal? SgstBamt { get; set; }

    public decimal? SgstBamtSc { get; set; }

    public decimal? SgstBamtFc { get; set; }

    public decimal? IgstAmnt { get; set; }

    public decimal? IgstAmntSc { get; set; }

    public decimal? IgstAmntFc { get; set; }

    public decimal? CgstAmnt { get; set; }

    public decimal? CgstAmntSc { get; set; }

    public decimal? CgstAmntFc { get; set; }

    public decimal? SgstAmnt { get; set; }

    public decimal? SgstAmntSc { get; set; }

    public decimal? SgstAmntFc { get; set; }

    public int? DepositNum { get; set; }

    public decimal? UtgstBamt { get; set; }

    public decimal? UtgstBamtS { get; set; }

    public decimal? UtgstBamtC { get; set; }

    public decimal? CsgstBamt { get; set; }

    public decimal? CsgstBamtS { get; set; }

    public decimal? CsgstBamtC { get; set; }

    public decimal? UtgstAmt { get; set; }

    public decimal? UtgstAmtSc { get; set; }

    public decimal? UtgstAmtFc { get; set; }

    public decimal? CsgstAmt { get; set; }

    public decimal? CsgstAmtSc { get; set; }

    public decimal? CsgstAmtFc { get; set; }

    public string? EncryptIv { get; set; }
}
