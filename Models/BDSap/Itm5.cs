using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Itm5
{
    public string ItemCode { get; set; } = null!;

    public int LineNum { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Project { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
