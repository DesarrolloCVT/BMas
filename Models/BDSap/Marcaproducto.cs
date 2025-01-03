using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Marcaproducto
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCodProveedor { get; set; }

    public string? UProveedor { get; set; }
}
