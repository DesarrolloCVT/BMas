using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tsh1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public DateTime? Date { get; set; }

    public int? ActType { get; set; }

    public string? LaborItem { get; set; }

    public int? StartTime { get; set; }

    public int? EndTime { get; set; }

    public int? Workorder { get; set; }

    public int? WorAbs { get; set; }

    public int? ServCall { get; set; }

    public string? CostCenter { get; set; }

    public string? FiProject { get; set; }

    public int? Location { get; set; }

    public string? Gpsdata { get; set; }

    public int? Branch { get; set; }

    public int? Break { get; set; }

    public int? NonBillTm { get; set; }

    public int? EffectTm { get; set; }

    public int? BillableTm { get; set; }

    public string? FullDay { get; set; }

    public int? LogInstanc { get; set; }

    public int? ProjectId { get; set; }

    public int? Subproject { get; set; }

    public int? StageId { get; set; }

    public decimal? Charged { get; set; }

    public string? Chargeable { get; set; }

    public string? EncryptIv { get; set; }

    public decimal? BreakHr { get; set; }

    public decimal? NonBillHr { get; set; }

    public decimal? EffectHr { get; set; }

    public decimal? BillableHr { get; set; }
}
