using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmConsolidadoCompra
{
    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string? CodProveedor { get; set; }

    public string? Proveedor { get; set; }

    public int? CantProdRequerido { get; set; }

    public int? StockSap { get; set; }

    public int? CantTotalRequerido { get; set; }

    public int? SaldoSap { get; set; }
}
