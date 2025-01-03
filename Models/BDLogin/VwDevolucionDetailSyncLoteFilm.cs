using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDevolucionDetailSyncLoteFilm
{
    public int? IdDevoFilm { get; set; }

    public string? CodProducto { get; set; }

    public string? LoteInterno { get; set; }

    public decimal? Cantidad { get; set; }
}
