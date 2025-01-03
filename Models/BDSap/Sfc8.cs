using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sfc8
{
    public int DocEntry { get; set; }

    public int PackageNum { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public int UomEntry { get; set; }

    public string? UnitMsr { get; set; }

    public decimal NumPerMsr { get; set; }
}
