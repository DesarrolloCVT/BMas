using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rci1
{
    public int Code { get; set; }

    public int LineNum { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }
}
