using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opkg
{
    public int PkgCode { get; set; }

    public string PkgType { get; set; } = null!;

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
}
