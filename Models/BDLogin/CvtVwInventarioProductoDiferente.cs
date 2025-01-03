using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInventarioProductoDiferente
{
    public int InventarioId { get; set; }

    public string? Usuario { get; set; }

    public string? BodegaPistoleo { get; set; }

    public int UbicacionPistoleo { get; set; }

    public string? RackPistoleo { get; set; }

    public string? BodegaSistema { get; set; }

    public int UbicacionSistema { get; set; }

    public string? RackSistema { get; set; }

    public int Npallet { get; set; }

    public int? Estado { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? CodProductoSistema { get; set; }

    public string? ProductoSistema { get; set; }

    public string Lote { get; set; } = null!;

    public string? LoteSistema { get; set; }

    public decimal Cantidad { get; set; }

    public int CantidadSistema { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
