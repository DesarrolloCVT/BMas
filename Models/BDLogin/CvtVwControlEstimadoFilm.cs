using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwControlEstimadoFilm
{
    public int DocNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public DateTime? StartDate { get; set; }

    public decimal? Producido { get; set; }

    public decimal? FilmInformadoImpreso { get; set; }

    public decimal? FilmImpresoEstimado { get; set; }

    public decimal? FilmInformadoEnfardador { get; set; }

    public decimal? FilmEnfardadorEstimado { get; set; }
}
