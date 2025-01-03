using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scr2
{
    public short RuleId { get; set; }

    public string GoalNum { get; set; } = null!;

    public short? TransTpVal { get; set; }

    public string? TransTpFld { get; set; }

    public string? PrfCntVal { get; set; }

    public string? PrfCntFld { get; set; }

    public string? DebitAct { get; set; }

    public string? CreditAct { get; set; }

    public string? RevSides { get; set; }

    public string? SrcTable { get; set; }

    public string? SrcField { get; set; }

    public string? SrcFieldFc { get; set; }

    public string? SrcFieldSc { get; set; }

    public string? Calc { get; set; }

    public string? CalcFc { get; set; }

    public string? CalcSc { get; set; }

    public string? CalcCond { get; set; }

    public string? CalcCondFc { get; set; }

    public string? CalcCondSc { get; set; }

    public string? CurrFld { get; set; }

    public string? CallProc { get; set; }

    public string? ExtCond { get; set; }
}
