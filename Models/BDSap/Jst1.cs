using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Jst1
{
    public int AbsId { get; set; }

    public int LineNum { get; set; }

    public string? Wtcode { get; set; }

    public int? BaseNum { get; set; }

    public int? BaseAbsId { get; set; }

    public int? BaseLine { get; set; }

    public int? LogInstanc { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TdsRate { get; set; }

    public decimal? SurRate { get; set; }

    public decimal? CessRate { get; set; }

    public decimal? HscRate { get; set; }

    public decimal? TaxbleAmnt { get; set; }

    public decimal? TxblAmntSc { get; set; }

    public decimal? TxblAmntFc { get; set; }

    public string? Category { get; set; }

    public string? Criteria { get; set; }

    public string? Type { get; set; }

    public string? RoundType { get; set; }

    public string? BaseType { get; set; }

    public string? Account { get; set; }

    public string? TdsAcc { get; set; }

    public string? SurAcc { get; set; }

    public string? CessAcc { get; set; }

    public string? HscAcc { get; set; }

    public decimal? Wtamnt { get; set; }

    public decimal? WtamntSc { get; set; }

    public decimal? WtamntFc { get; set; }

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
}
