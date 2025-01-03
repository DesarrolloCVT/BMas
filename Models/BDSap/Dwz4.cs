using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dwz4
{
    public int WizardId { get; set; }

    public string? CheckLine { get; set; }

    public string? ExeChkLine { get; set; }

    public int RowId { get; set; }

    public string? CardCode { get; set; }

    public int? LetterNum { get; set; }

    public int? DunnLevel { get; set; }

    public string? CardName { get; set; }

    public string? DocCur { get; set; }

    public int? DocType { get; set; }

    public int? DocNum { get; set; }

    public short? InstlmntId { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? LastLvlDte { get; set; }

    public DateTime? LastDunDte { get; set; }

    public DateTime? NewLvlDate { get; set; }

    public string? DocAmntLc { get; set; }

    public string? DocAmntFc { get; set; }

    public string? OpenAmtLc { get; set; }

    public string? OpenAmtFc { get; set; }

    public int? IntrstDays { get; set; }

    public decimal? IntrstPc { get; set; }

    public string? IntAmntLc { get; set; }

    public string? IntAmntFc { get; set; }

    public string? InclAmntLc { get; set; }

    public string? InclAmntFc { get; set; }

    public string? FeeLc { get; set; }

    public string? FeeFc { get; set; }

    public string? AllTotalLc { get; set; }

    public string? AllTotalFc { get; set; }

    public string? AutoPost { get; set; }

    public int? LineProp { get; set; }

    public int? YearDays { get; set; }

    public decimal? YearlyRate { get; set; }

    public string? LetterFrmt { get; set; }

    public decimal? MinBlan { get; set; }

    public string? GrpMethod { get; set; }

    public int? DocEntry { get; set; }

    public string? DocRate { get; set; }

    public string? FeeCurr { get; set; }

    public decimal? OrigFee { get; set; }

    public string? MinBalCurr { get; set; }

    public string? LvlUpdated { get; set; }

    public string? DunAddr { get; set; }

    public string? DocText { get; set; }

    public int? ParentId { get; set; }

    public string? BpCode2 { get; set; }

    public string? BpType { get; set; }

    public string? CardName2 { get; set; }

    public string? Comment { get; set; }

    public int? Bplid { get; set; }
}
