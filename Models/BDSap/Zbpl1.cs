using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zbpl1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? UBplid { get; set; }

    public string? UBplname { get; set; }

    public string? UBplusr { get; set; }
}
