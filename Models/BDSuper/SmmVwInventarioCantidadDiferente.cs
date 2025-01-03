using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwInventarioCantidadDiferente
{
    public int InventarioId { get; set; }

    public int? IdUsuario { get; set; }

    public int? SiteId { get; set; }

    public string? Dun14 { get; set; }

    public string? CodProducto { get; set; }

    public string? LoteSistema { get; set; }

    public int? Cantidad { get; set; }

    public decimal? CantidadSistema { get; set; }

    public string? ItemName { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
