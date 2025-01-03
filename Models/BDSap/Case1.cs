using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Case1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? ShortName { get; set; }

    public string? Account { get; set; }

    public int? OrigAbsEnt { get; set; }

    public int? OrigObjTyp { get; set; }

    public int? OrigDocNum { get; set; }

    public int? OrigInsNum { get; set; }

    public int? OrigTrnsId { get; set; }

    public int? OrigTrnsLn { get; set; }

    public int? LnkRecnAbs { get; set; }

    public int? LnkRecnObj { get; set; }

    public int? LnkRecnNum { get; set; }

    public int? LnkRecnIns { get; set; }

    public int? LnkRecnTrn { get; set; }

    public int? LnkRecnLn { get; set; }

    public string? InconsType { get; set; }

    public int? ReconNum { get; set; }

    public int? NewRcnNum { get; set; }

    public string? CredDeb { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountSc { get; set; }

    public int? TransId { get; set; }

    public int? TransLine { get; set; }

    public decimal? X { get; set; }

    public decimal? Y { get; set; }

    public decimal? Z { get; set; }

    public int? LnkObjAbsE { get; set; }

    public int? LinkObjTyp { get; set; }

    public int? LinkDocNum { get; set; }

    public int? LinkInsNum { get; set; }

    public int? LinkTrnsId { get; set; }

    public int? LinkTrnsLn { get; set; }

    public decimal? TrnsTtlAmt { get; set; }

    public decimal? TrnsTtlFc { get; set; }
}
