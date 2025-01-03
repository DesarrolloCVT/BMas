using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ScategoriaProducto
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UCategoria { get; set; } = null!;

    public string USubCategoria { get; set; } = null!;

    public string UCodCategoria { get; set; } = null!;

    public string UCodSubCategoria { get; set; } = null!;
}
