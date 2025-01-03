using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInventarioEstadoProducto
{
    public int InventarioId { get; set; }

    public string CodProducto { get; set; } = null!;

    public int InventarioEstadoId { get; set; }

    public short Estado { get; set; }

    public string? Supervisor { get; set; }

    public string? Contador { get; set; }

    public int? CantInventariada { get; set; }

    public int? CantWms { get; set; }

    public int? CantSap { get; set; }
}
