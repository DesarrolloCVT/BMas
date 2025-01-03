using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ouom
{
    public int UomEntry { get; set; }

    public string UomCode { get; set; } = null!;

    public string? UomName { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? Length1 { get; set; }

    public short? Len1Unit { get; set; }

    public decimal? Length2 { get; set; }

    public short? Len2Unit { get; set; }

    public decimal? Width1 { get; set; }

    public short? Wdth1Unit { get; set; }

    public decimal? Width2 { get; set; }

    public short? Wdth2Unit { get; set; }

    public decimal? Height1 { get; set; }

    public short? Hght1Unit { get; set; }

    public decimal? Height2 { get; set; }

    public short? Hght2Unit { get; set; }

    public decimal? Volume { get; set; }

    public short? VolUnit { get; set; }

    public decimal? Weight1 { get; set; }

    public short? WghtUnit { get; set; }

    public decimal? Weight2 { get; set; }

    public short? Wght2Unit { get; set; }

    public string? IntSymbol { get; set; }

    public int? EwbUnit { get; set; }

    public decimal? Ppweight1 { get; set; }

    public short? Ppwe1Unit { get; set; }

    public decimal? Ppweight2 { get; set; }

    public short? Ppwe2Unit { get; set; }

    public string? UX4rInterkey { get; set; }
}
