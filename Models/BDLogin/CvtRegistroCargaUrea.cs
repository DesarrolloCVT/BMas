using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroCargaUrea
{
    public int IdCargaUrea { get; set; }

    public string? Patente { get; set; }

    public DateOnly? FechaCarga { get; set; }

    public decimal? LitrosCargados { get; set; }

    public int? Nestanque { get; set; }

    public int? Responsable { get; set; }

    public decimal? CostoxCarga { get; set; }

    public decimal? TotalCarga { get; set; }

    public decimal? Odometro { get; set; }
}
