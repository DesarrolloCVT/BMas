using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetalleRapel
{
    public string CodCliente { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? FamiliaPro { get; set; }

    public string Sucursal { get; set; } = null!;

    public string? Marca { get; set; }

    public decimal? Centralizacion { get; set; }

    public decimal? RepoInt { get; set; }

    public decimal? Daymon { get; set; }

    public decimal? LogAuto { get; set; }

    public decimal? MermaCero { get; set; }

    public decimal? Rappel { get; set; }

    public decimal? Plataforma { get; set; }

    public decimal? Acuerdo { get; set; }

    public decimal? TotalRapel { get; set; }
}
