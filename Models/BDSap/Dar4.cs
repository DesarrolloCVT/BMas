using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dar4
{
    public int ArcEntry { get; set; }

    public int? Series { get; set; }

    public int LineId { get; set; }

    public string? DocType { get; set; }

    public int? DocNum { get; set; }

    public int? DocAbs { get; set; }

    public decimal? Total { get; set; }

    public DateTime? RefDate { get; set; }

    public string? Type { get; set; }

    public string? Remarks { get; set; }
}
