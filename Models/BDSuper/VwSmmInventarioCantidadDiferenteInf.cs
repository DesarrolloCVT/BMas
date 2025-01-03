using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmInventarioCantidadDiferenteInf
{
    public int InventarioId { get; set; }

    public int? PackageSscc { get; set; }

    public int? CantInvent { get; set; }

    public decimal? CantSistema { get; set; }

    public int CodUbicacionInv { get; set; }

    public string? BodegaInv { get; set; }

    public int CodUbicacionSist { get; set; }

    public string? BodegaSist { get; set; }

    public string? TipoEmpaqueInv { get; set; }

    public string? TipoEmpSist { get; set; }

    public string? CodProdInv { get; set; }

    public string CodProdSist { get; set; } = null!;

    public string? CodBarInv { get; set; }

    public string? CodBarSist { get; set; }

    public DateTime? Fecha { get; set; }

    public string? CodProducto { get; set; }

    public string? ItemName { get; set; }
}
