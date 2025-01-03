using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmDevolucion
{
    public int IdDevoFilm { get; set; }

    public int? IdBodega { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Motivo { get; set; }

    public int? Estado { get; set; }

    public int? IdUsuario { get; set; }

    public string? Comentarios { get; set; }

    public string? Proveedor { get; set; }

    public int? CantidadBobinas { get; set; }
}
