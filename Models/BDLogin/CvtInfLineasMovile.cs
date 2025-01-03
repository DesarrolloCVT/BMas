using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfLineasMovile
{
    public int Nlinea { get; set; }

    public string Sim { get; set; } = null!;

    public string Serie { get; set; } = null!;

    public int TipoEquipo { get; set; }

    public int Marca { get; set; }

    public string Modelo { get; set; } = null!;

    public string? Asignado { get; set; }

    public string CodPlan { get; set; } = null!;

    public DateTime FechaAdquisicion { get; set; }

    public int? MarcaAsignadoMovistar { get; set; }

    public string? ModeloAsignadoMovistar { get; set; }

    public int? Area { get; set; }

    public int? ValorCuota { get; set; }

    public string? SerieAsignadoMovistar { get; set; }

    public int? MesesFaltCambio { get; set; }
}
