using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ado7
{
    public int DocEntry { get; set; }

    public int PackageNum { get; set; }

    public string? PackageTyp { get; set; }

    public decimal? Weight { get; set; }

    public short? WeightUnit { get; set; }

    public string ObjType { get; set; } = null!;

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
