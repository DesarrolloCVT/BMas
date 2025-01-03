using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cpv5
{
    public int AbsEntry { get; set; }

    public string Wtcode { get; set; } = null!;

    public decimal? Rate { get; set; }

    public decimal? TaxbleAmnt { get; set; }

    public decimal? TxblAmntSc { get; set; }

    public decimal? TxblAmntFc { get; set; }

    public decimal? Wtamnt { get; set; }

    public decimal? WtamntSc { get; set; }

    public decimal? WtamntFc { get; set; }

    public decimal? ApplAmnt { get; set; }

    public decimal? ApplAmntSc { get; set; }

    public decimal? ApplAmntFc { get; set; }

    public string? Category { get; set; }

    public string? Criteria { get; set; }

    public string? Account { get; set; }

    public string? Type { get; set; }

    public string? RoundType { get; set; }

    public string? BaseType { get; set; }

    public int BaseAbsEnt { get; set; }

    public int? BaseLine { get; set; }

    public int? BaseNum { get; set; }

    public int LineNum { get; set; }

    public int? BaseRef { get; set; }

    public string? Status { get; set; }

    public int? TrgType { get; set; }

    public int? TrgAbsEntr { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public int Doc1LineNo { get; set; }

    public string? WtLineType { get; set; }

    public string? TxblCurr { get; set; }

    public string? DtblCurr { get; set; }

    public decimal? DtblRate { get; set; }

    public decimal? TxblRate { get; set; }

    public decimal? DtblAmount { get; set; }

    public string? TdsAcc { get; set; }

    public string? SurAcc { get; set; }

    public string? CessAcc { get; set; }

    public string? HscAcc { get; set; }

    public decimal? TdsRate { get; set; }

    public decimal? SurRate { get; set; }

    public decimal? CessRate { get; set; }

    public decimal? HscRate { get; set; }

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

    public decimal? TdsAppl { get; set; }

    public decimal? TdsApplSc { get; set; }

    public decimal? TdsApplFc { get; set; }

    public decimal? SurAppl { get; set; }

    public decimal? SurApplSc { get; set; }

    public decimal? SurApplFc { get; set; }

    public decimal? CessAppl { get; set; }

    public decimal? CessApplSc { get; set; }

    public decimal? CessApplFc { get; set; }

    public decimal? HscAppl { get; set; }

    public decimal? HscApplSc { get; set; }

    public decimal? HscApplFc { get; set; }

    public int? BatchNum { get; set; }

    public string? InCstcode { get; set; }

    public string? OutCstcode { get; set; }

    public decimal? DpmWtapl { get; set; }

    public decimal? DpmWtaplSc { get; set; }

    public decimal? DpmWtaplFc { get; set; }

    public int? WttypeId { get; set; }

    public decimal? LnBsAmt { get; set; }

    public decimal? LnBsAmtSc { get; set; }

    public decimal? LnBsAmtFc { get; set; }

    public decimal? LnCmTamt { get; set; }

    public decimal? LnCmTamtSc { get; set; }

    public decimal? LnCmTamtFc { get; set; }

    public string? Tdstype { get; set; }

    public string? IgstAcc { get; set; }

    public string? CgstAcc { get; set; }

    public string? SgstAcc { get; set; }

    public decimal? IgstAmnt { get; set; }

    public decimal? IgstAmntSc { get; set; }

    public decimal? IgstAmntFc { get; set; }

    public decimal? CgstAmnt { get; set; }

    public decimal? CgstAmntSc { get; set; }

    public decimal? CgstAmntFc { get; set; }

    public decimal? SgstAmnt { get; set; }

    public decimal? SgstAmntSc { get; set; }

    public decimal? SgstAmntFc { get; set; }

    public decimal? IgstRate { get; set; }

    public decimal? CgstRate { get; set; }

    public decimal? SgstRate { get; set; }

    public decimal? IgstBamt { get; set; }

    public decimal? IgstBamtSc { get; set; }

    public decimal? IgstBamtFc { get; set; }

    public decimal? CgstBamt { get; set; }

    public decimal? CgstBamtSc { get; set; }

    public decimal? CgstBamtFc { get; set; }

    public decimal? SgstBamt { get; set; }

    public decimal? SgstBamtSc { get; set; }

    public decimal? SgstBamtFc { get; set; }

    public decimal? IgstAppl { get; set; }

    public decimal? IgstApplSc { get; set; }

    public decimal? IgstApplFc { get; set; }

    public decimal? CgstAppl { get; set; }

    public decimal? CgstApplSc { get; set; }

    public decimal? CgstApplFc { get; set; }

    public decimal? SgstAppl { get; set; }

    public decimal? SgstApplSc { get; set; }

    public decimal? SgstApplFc { get; set; }

    public string? UtgstAcc { get; set; }

    public string? CsgstAcc { get; set; }

    public decimal? UtgstAmt { get; set; }

    public decimal? UtgstAmtSc { get; set; }

    public decimal? UtgstAmtFc { get; set; }

    public decimal? CsgstAmt { get; set; }

    public decimal? CsgstAmtSc { get; set; }

    public decimal? CsgstAmtFc { get; set; }

    public decimal? UtgstRate { get; set; }

    public decimal? CsgstRate { get; set; }

    public decimal? UtgstBamt { get; set; }

    public decimal? UtgstBamtS { get; set; }

    public decimal? UtgstBamtF { get; set; }

    public decimal? CsgstBamt { get; set; }

    public decimal? CsgstBamtS { get; set; }

    public decimal? CsgstBamtF { get; set; }

    public decimal? UtgstAppl { get; set; }

    public decimal? UtgstApplS { get; set; }

    public decimal? UtgstApplF { get; set; }

    public decimal? CsgstAppl { get; set; }

    public decimal? CsgstApplS { get; set; }

    public decimal? CsgstApplF { get; set; }

    public string? EncryptIv { get; set; }

    public string? TcsIntAcct { get; set; }

    public string? SurIntAcct { get; set; }

    public string? CesIntAcct { get; set; }

    public string? HscIntAcct { get; set; }

    public string? LnIntAcct { get; set; }

    public decimal? FixedAmnt { get; set; }

    public decimal? FixedAmtSc { get; set; }

    public decimal? FixedAmtFc { get; set; }

    public decimal? BaseQty { get; set; }
}
