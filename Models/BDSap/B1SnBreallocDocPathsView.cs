using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1SnBreallocDocPathsView
{
    public int? ApplyType { get; set; }

    public int? ApplyEntry { get; set; }

    public int? ApplyLine { get; set; }

    public int AppSubLine { get; set; }

    public int DocType { get; set; }

    public int DocEntry { get; set; }

    public int DocLine { get; set; }

    public int DocSubLine { get; set; }
}
