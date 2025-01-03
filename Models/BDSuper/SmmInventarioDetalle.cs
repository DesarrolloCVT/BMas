using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmInventarioDetalle
{
    public int InventarioDetId { get; set; }

    public int InventarioId { get; set; }

    public string? Dun14 { get; set; }

    public string? CodProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public int? SiteId { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? UbiPasillo { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? PackageSscc { get; set; }

    public int? LocationId { get; set; }

    public string? CantEmp { get; set; }

    public int? CantBase { get; set; }

    public string? TipoEmpaque { get; set; }
}
