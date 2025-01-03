using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dwz2
{
    public int WizardId { get; set; }

    public string? CardCode { get; set; }

    public int LetterNum { get; set; }

    public decimal? TotalFee { get; set; }

    public string? FeeCurr { get; set; }

    public decimal? TtlopnIntr { get; set; }

    public string? EdunLevel { get; set; }

    public string? OpnIntrCrr { get; set; }

    public int DocAbs { get; set; }

    public int? DocNum { get; set; }

    public short InstlmntId { get; set; }

    public decimal? IntrstPc { get; set; }

    public decimal? IntrstAmnt { get; set; }

    public string? IntrstCurr { get; set; }

    public string? ChckLine { get; set; }

    public int? IntrstDays { get; set; }

    public int DocType { get; set; }

    public DateTime? DueDate { get; set; }

    public string? LetterLvl { get; set; }

    public decimal? OpenSum { get; set; }

    public string? OpenCurr { get; set; }

    public decimal? SumIntrClc { get; set; }

    public string? FolioNum { get; set; }

    public string? LvlUpdated { get; set; }

    public decimal? TotalFeeFc { get; set; }

    public decimal? TotalFeeLc { get; set; }

    public decimal? TotalFeeSc { get; set; }

    public decimal? TtlopnInFc { get; set; }

    public decimal? TtlopnInSc { get; set; }

    public decimal? IntrAmtFc { get; set; }

    public decimal? IntrAmtSc { get; set; }

    public decimal? OpenSumFc { get; set; }

    public decimal? OpenSumSc { get; set; }

    public string? ExeChkLine { get; set; }

    public string? AutoPost { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? UnpaidBoEv { get; set; }

    public int? BoEnumber { get; set; }

    public string? BoEstatus { get; set; }

    public DateTime? BoEdate { get; set; }

    public int? BoEkey { get; set; }

    public string? Bptype { get; set; }

    public int? Bplid { get; set; }
}
