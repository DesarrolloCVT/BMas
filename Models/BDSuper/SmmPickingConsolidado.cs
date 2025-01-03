using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmPickingConsolidado
{
    public int IdPickingSmm { get; set; }

    public DateTime? FechaConsolidado { get; set; }

    public string? Producto { get; set; }

    public int? CantidadPikeada { get; set; }

    public DateTime? FechaPickeada { get; set; }

    public int? IdUsuario { get; set; }

    public string? DeptoVentas { get; set; }
}
