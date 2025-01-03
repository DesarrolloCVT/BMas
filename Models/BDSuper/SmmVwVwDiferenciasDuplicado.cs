using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwVwDiferenciasDuplicado
{
    public int InventarioDetId { get; set; }

    public int InventarioId { get; set; }

    public string? Dun14 { get; set; }

    public string? CodProducto { get; set; }

    public int? Cantidad { get; set; }

    public int? SiteId { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
