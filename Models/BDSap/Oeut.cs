using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oeut
{
    public int AbsEntry { get; set; }

    public string UnitCode { get; set; } = null!;

    public string? UnitName { get; set; }
}
