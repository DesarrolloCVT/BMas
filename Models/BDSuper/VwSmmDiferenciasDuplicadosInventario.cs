using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmDiferenciasDuplicadosInventario
{
    public int InventarioId { get; set; }

    public int? Npallet { get; set; }

    public int? Cantidad { get; set; }

    public int InventarioDetId { get; set; }

    public string? CodProducto { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? TipoEmpaque { get; set; }

    public string NombreUsuario { get; set; } = null!;
}
