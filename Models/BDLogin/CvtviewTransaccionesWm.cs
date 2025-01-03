using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtviewTransaccionesWm
{
    public string Trx { get; set; } = null!;

    public int? CodUbicacion { get; set; }

    public string? DescUbicacion { get; set; }

    public string? SiteDescription { get; set; }

    public string? WarehouseDescription { get; set; }

    public string? PackageSscc { get; set; }

    public string? CodProducto { get; set; }

    public string? DescProducto { get; set; }

    public int Cantidad { get; set; }

    public string? Dia { get; set; }

    public DateTime? FecIngreso { get; set; }

    public DateTime? FecSalida { get; set; }

    public string? StaffName { get; set; }
}
