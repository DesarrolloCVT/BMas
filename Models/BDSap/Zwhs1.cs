using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zwhs1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UKardexFg { get; set; }

    public string? ULvBodFg { get; set; }

    public int UBplid { get; set; }
}
