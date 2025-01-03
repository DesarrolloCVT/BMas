using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Msn4
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Selected { get; set; }

    public string? TmpForMrp { get; set; }

    public DateTime? WorDueDate { get; set; }

    public DateTime? DsmDueDate { get; set; }

    public DateTime? NorDueDate { get; set; }

    public short? Interval { get; set; }

    public decimal? Multiple { get; set; }

    public decimal? MinOrdrQty { get; set; }

    public int? LeadTime { get; set; }

    public string? PrcrmntMtd { get; set; }

    public int? ToleranDay { get; set; }

    public string? CompoWh { get; set; }
}
