using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Slm1
{
    public int DocId { get; set; }

    public int LineId { get; set; }

    public short? RuleId { get; set; }

    public short? GoalNum { get; set; }

    public short? TransType { get; set; }

    public string? PrfCntVal { get; set; }

    public string? PrfCntOrig { get; set; }

    public string? Checked { get; set; }

    public string? Status { get; set; }

    public string? Enabled { get; set; }

    public string? DebitAct { get; set; }

    public string? CreditAct { get; set; }

    public string? RevSides { get; set; }

    public decimal? Src { get; set; }

    public decimal? SrcFc { get; set; }

    public decimal? SrcSc { get; set; }

    public decimal? SrcCalc { get; set; }

    public decimal? SrcCalcFc { get; set; }

    public decimal? SrcCalcSc { get; set; }

    public decimal? FinalSum { get; set; }

    public decimal? FinalSumFc { get; set; }

    public decimal? FinalSumSc { get; set; }

    public string? Currency { get; set; }

    public string? MainTable { get; set; }

    public string? Pkfield0 { get; set; }

    public string? Pkfield1 { get; set; }

    public string? Pkfield2 { get; set; }

    public string? Pkfield3 { get; set; }

    public string? Pkfield4 { get; set; }

    public string? Pkfield5 { get; set; }

    public string? Pkfield6 { get; set; }

    public string? Pkfield7 { get; set; }

    public string? Pkfield8 { get; set; }

    public string? Pkfield9 { get; set; }
}
