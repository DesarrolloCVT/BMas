using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmListadoPreciosDistribucionApi
{
    public string? UndMedida { get; set; }

    public int? CantidadXUpc { get; set; }

    public int? UomEntry { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Price { get; set; }

    public string? Impuesto { get; set; }

    public int? Rate { get; set; }

    public int? Neto { get; set; }

    public string? BcdCode { get; set; }
}
