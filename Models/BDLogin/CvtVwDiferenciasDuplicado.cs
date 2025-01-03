using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDiferenciasDuplicado
{
    public int InventarioDetId { get; set; }

    public int InventarioId { get; set; }

    public int Npallet { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public int Ubicacion { get; set; }

    public DateTime? Fproduccion { get; set; }

    public DateTime? Fvencimiento { get; set; }

    public string Lote { get; set; } = null!;

    public string? Usuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
