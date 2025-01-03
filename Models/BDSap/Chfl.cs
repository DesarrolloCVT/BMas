using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Chfl
{
    public string ObjName { get; set; } = null!;

    public short FldIndex { get; set; }

    public string? FldNum { get; set; }

    public string? DispName { get; set; }

    public string? GroupBy { get; set; }

    public string? Visible { get; set; }

    public string? DispDesc { get; set; }

    public string? SortOrder { get; set; }

    public short? VisIndex { get; set; }
}
