using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Msn5
{
    public int AbsEntry { get; set; }

    public string DocType { get; set; } = null!;

    public int DocEntry { get; set; }

    public string? Selected { get; set; }

    public string DocSubType { get; set; } = null!;
}
