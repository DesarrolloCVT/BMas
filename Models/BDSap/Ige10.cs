using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ige10
{
    public int DocEntry { get; set; }

    public int LineSeq { get; set; }

    public int AftLineNum { get; set; }

    public int OrderNum { get; set; }

    public string? LineType { get; set; }

    public string? LineText { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
