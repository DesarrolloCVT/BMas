using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDevolDetalleExportFilm
{
    public int FolioDevol { get; set; }

    public int? Nbobina { get; set; }

    public string? CodProducto { get; set; }

    public string? DescProducto { get; set; }

    public int? IdBodega { get; set; }

    public string? LoteInterno { get; set; }

    public string? LoteProveedor { get; set; }

    public decimal? PesoBruto { get; set; }
}
