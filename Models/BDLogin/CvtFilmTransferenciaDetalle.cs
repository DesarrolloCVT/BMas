using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmTransferenciaDetalle
{
    public int IdDetTranferencia { get; set; }

    public int? Nbobina { get; set; }

    public decimal? PesoBruto { get; set; }

    public int? IdTransferenciaFilm { get; set; }

    public decimal? PesoNeto { get; set; }

    public decimal? PesoCono { get; set; }
}
