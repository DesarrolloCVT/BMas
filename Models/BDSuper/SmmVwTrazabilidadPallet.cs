using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwTrazabilidadPallet
{
    public int? PackageId { get; set; }

    public string? Npallet { get; set; }

    public string Entidad { get; set; } = null!;

    public string? Operacion { get; set; }

    public int? Identidad { get; set; }

    public string Tipo { get; set; } = null!;

    public int? Ndocumento { get; set; }

    public decimal? CantidadInicial { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public DateTime? PackageProductionDate { get; set; }

    public DateTime? PackageExpiresDate { get; set; }

    public string? ReceptionNote { get; set; }

    public string? PackageLot { get; set; }

    public string CodProducto { get; set; } = null!;

    public string? ArticleDescription { get; set; }

    public string Estado { get; set; } = null!;

    public string? Bodega { get; set; }
}
