using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osvt
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public string? Descript { get; set; }

    public string? NameDesc { get; set; }
}
