using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait2
{
    public string ItemCode { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
