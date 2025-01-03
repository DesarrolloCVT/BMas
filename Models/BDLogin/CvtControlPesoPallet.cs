using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlPesoPallet
{
    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Nlinea { get; set; }

    public TimeOnly? HoraPeso { get; set; }

    public string Grupo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Sscc { get; set; }

    public decimal? PesoPallet { get; set; }

    public int CantidadCreado { get; set; }

    public decimal? PesoUm { get; set; }

    public decimal? PesoIdeal { get; set; }

    public int PesoPromedioFilm { get; set; }

    public decimal? PesoAproximadoMp { get; set; }

    public decimal? DosificadoPromedioContenedora { get; set; }
}
