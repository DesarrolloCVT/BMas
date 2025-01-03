using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aph1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? StageId { get; set; }

    public int? Pos { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Close { get; set; }

    public DateTime? Finishdate { get; set; }

    public int? Task { get; set; }

    public string? Dscription { get; set; }

    public decimal? Expcosts { get; set; }

    public decimal? InvAmtAr { get; set; }

    public decimal? OpenAmtAr { get; set; }

    public decimal? InvAmtAp { get; set; }

    public decimal? OpenAmtAp { get; set; }

    public decimal? Percent { get; set; }

    public string? Finish { get; set; }

    public int? Owner { get; set; }

    public int? StageDep1 { get; set; }

    public int? StageDep2 { get; set; }

    public int? StageDep3 { get; set; }

    public int? StageDep4 { get; set; }

    public string? StDp1Type { get; set; }

    public string? StDp2Type { get; set; }

    public string? StDp3Type { get; set; }

    public string? StDp4Type { get; set; }

    public int? StDp1Abs { get; set; }

    public int? StDp2Abs { get; set; }

    public int? StDp3Abs { get; set; }

    public int? StDp4Abs { get; set; }

    public int LogInstanc { get; set; }

    public int? AtcEntry { get; set; }

    public string? UniqueId { get; set; }

    public string? EncryptIv { get; set; }
}
