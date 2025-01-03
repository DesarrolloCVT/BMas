using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmDevolucionDetalle
{
    public int IdDetDevolFilm { get; set; }

    public int? IdDevoFilm { get; set; }

    public int? Nbobina { get; set; }

    public string? CodProducto { get; set; }

    public string? DescripcionProducto { get; set; }

    public decimal? PesoBruto { get; set; }
}
