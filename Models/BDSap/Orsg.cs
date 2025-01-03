using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orsg
{
    public short ResTypCod { get; set; }

    public string ResGrpNam { get; set; } = null!;

    public string? UserSign { get; set; }
}
