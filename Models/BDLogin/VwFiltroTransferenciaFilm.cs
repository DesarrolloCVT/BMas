using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwFiltroTransferenciaFilm
{
    public int? IdBodega { get; set; }

    public int Nbobina { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoNeto { get; set; }

    public decimal? PesoCono { get; set; }

    public string? Producto { get; set; }

    public string? LoteInterno { get; set; }
}
