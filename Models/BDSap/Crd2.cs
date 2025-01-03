using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Crd2
{
    public string CardCode { get; set; } = null!;

    public int LineNum { get; set; }

    public string? PymCode { get; set; }

    public int? LogInstanc { get; set; }

    public short? ObjType { get; set; }
}
