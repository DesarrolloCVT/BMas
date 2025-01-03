using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwNotacreditoDetalleCompra
{
    public int IdNotaCredito { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Total { get; set; }

    public decimal? Descuento { get; set; }
}
