using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocfw
{
    public int Cfwid { get; set; }

    public string Cfwname { get; set; } = null!;

    public string? LineNum { get; set; }

    public string? Postable { get; set; }

    public int? FatherNum { get; set; }

    public short? Levels { get; set; }

    public short? GroupMask { get; set; }

    public int? GroupLine { get; set; }

    public int? ExtrMatch { get; set; }

    public int? IntrMatch { get; set; }

    public int? RateDifCfw { get; set; }

    public short? DataSource { get; set; }

    public short? Attr { get; set; }

    public short? Direction { get; set; }
}
