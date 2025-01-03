using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmRepaletizado
{
    public int IdRepaletizado { get; set; }

    public int? IdBodega { get; set; }

    public DateTime? FechaRepaletizado { get; set; }

    public string? CodProducto { get; set; }

    public decimal? PesoBrutoOrigen { get; set; }

    public int? NbobinaDestino { get; set; }

    public int? NbobinaOrigen { get; set; }

    public int? IdUsuario { get; set; }

    public decimal? PesoBrutoPickeado { get; set; }
}
