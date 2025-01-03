using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDetalleLineasMovilesxPlan
{
    public int Nlinea { get; set; }

    public string Sim { get; set; } = null!;

    public string Serie { get; set; } = null!;

    public string TipoEquipo { get; set; } = null!;

    public string? Marca { get; set; }

    public string Modelo { get; set; } = null!;

    public string? Asignado { get; set; }

    public DateTime FechaAdquisicion { get; set; }

    public string? MarcaAsignada { get; set; }

    public string? ModeloAsignadoMovistar { get; set; }

    public int? Area { get; set; }

    public string? SerieAsignadoMovistar { get; set; }

    public int? MesesFaltCambio { get; set; }

    public string CodPlan { get; set; } = null!;

    public string PlanNombre { get; set; } = null!;

    public string DetallePlan { get; set; } = null!;

    public int? ValorCuota { get; set; }

    public int CargoFijoNeto { get; set; }

    public int? TotalPagoRestante { get; set; }
}
