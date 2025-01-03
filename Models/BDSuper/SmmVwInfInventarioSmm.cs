using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwInfInventarioSmm
{
    public int Folio { get; set; }

    public string? Bodega { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }
}
