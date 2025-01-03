using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Clg2
{
    public int ClgCode { get; set; }

    public int LineNum { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public int? LogInstanc { get; set; }
}
