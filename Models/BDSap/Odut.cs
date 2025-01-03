using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odut
{
    public string TermCode { get; set; } = null!;

    public string? TermName { get; set; }

    public string? GrpMethod { get; set; }

    public short? YearDays { get; set; }

    public short? MonthDays { get; set; }

    public string? RemIntrst { get; set; }

    public string? XchgOrig { get; set; }

    public decimal? YearlyRate { get; set; }

    public short? MaxLevel { get; set; }

    public decimal? TotalFee { get; set; }

    public string? FeeCurr { get; set; }

    public decimal? MinBalance { get; set; }

    public string? BalCurr { get; set; }

    public string? CalcIntr { get; set; }

    public string? LetterFrmt { get; set; }

    public string? HiLtrFrmt { get; set; }

    public string? DateCalInt { get; set; }

    public string? AutoPost { get; set; }

    public string? IntrAcc { get; set; }

    public string? FeeAcc { get; set; }
}
