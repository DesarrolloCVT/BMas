using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dar3
{
    public int ArcEntry { get; set; }

    public int LineId { get; set; }

    public string? DocType { get; set; }

    public int? DocAbs { get; set; }

    public int? DocNum { get; set; }

    public string? DocSubType { get; set; }

    public string? Pindicator { get; set; }
}
