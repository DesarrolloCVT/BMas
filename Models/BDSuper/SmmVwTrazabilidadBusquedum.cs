using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwTrazabilidadBusquedum
{
    public int SiteId { get; set; }

    public string? SiteDescription { get; set; }

    public int LayoutId { get; set; }

    public int PackageId { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Nrecepcion { get; set; }

    public DateTime? Frecepcion { get; set; }

    public string? Proveedor { get; set; }

    public string? Npallet { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Estado { get; set; }

    public string? Lote { get; set; }

    public string? CodBarr { get; set; }

    public decimal CantReserva { get; set; }

    public string? Ubicacion { get; set; }

    public DateTime? PackageProductionDate { get; set; }

    public DateTime? PackageExpiresDate { get; set; }

    public string? Info1 { get; set; }

    public string? Info2 { get; set; }

    public decimal? CantInicial { get; set; }

    public DateTime? PackageInDate { get; set; }

    public DateTime PackageOutDate { get; set; }
}
