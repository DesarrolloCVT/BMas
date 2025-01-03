using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Alr3
{
    public int Code { get; set; }

    public int Location { get; set; }

    public int Line { get; set; }

    public string? Value { get; set; }

    public string? ObjType { get; set; }

    public string? KeyStr { get; set; }
}
