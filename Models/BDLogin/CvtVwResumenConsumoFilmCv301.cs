using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenConsumoFilmCv301
{
    public string Tipo { get; set; } = null!;

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public string Grupo { get; set; } = null!;

    public int? TotalPallets { get; set; }

    public string? CtaCostoVenta { get; set; }

    public decimal? Porcentaje { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? CantidadFilmTotal { get; set; }

    public decimal? CantidadFilmConsumir { get; set; }

    public string? CtaExistenciaFilm { get; set; }
}
