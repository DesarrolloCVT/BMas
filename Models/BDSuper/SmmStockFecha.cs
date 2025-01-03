using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmStockFecha
{
    public int Bodega { get; set; }

    public string Producto { get; set; } = null!;

    public DateTime FechaProduccion { get; set; }

    public decimal? Cantidad { get; set; }
}
