using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwValidadorCodigosBarra
{
    public string CodigoProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? CodigoBarras { get; set; }

    public int? VecesIngresado { get; set; }

    public int? LargoIngresado { get; set; }

    public string Estado { get; set; } = null!;
}
