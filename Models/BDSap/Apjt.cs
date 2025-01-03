using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apjt
{
    public int DocEntry { get; set; }

    public string? TempType { get; set; }

    public string? TempName { get; set; }

    public int LogInstanc { get; set; }

    public int? UserSign { get; set; }

    public int? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? TempDesc { get; set; }
}
