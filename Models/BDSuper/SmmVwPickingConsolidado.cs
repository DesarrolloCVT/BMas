using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwPickingConsolidado
{
    public string DeptoVentas { get; set; } = null!;

    public DateOnly? FechaEntrega { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? CantidadSolicitada { get; set; }

    public int? CantidadPikear { get; set; }
}
