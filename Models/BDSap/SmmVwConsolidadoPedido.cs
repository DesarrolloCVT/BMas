using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwConsolidadoPedido
{
    public string DeptoVentas { get; set; } = null!;

    public DateOnly? FechaEntrega { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? CantidadSolicitada { get; set; }

    public int? CantidadPendienteFacturar { get; set; }

    public int? CantidadEntregar { get; set; }
}
