using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEtiquetaFilm
{
    public string? CodProducto { get; set; }

    public string? Descripcion { get; set; }

    public string? Bodega { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? Estado { get; set; }

    public int? NumRecepcion { get; set; }

    public string? LoteInterno { get; set; }

    public string? LoteProveedor { get; set; }

    public int Nbobina { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoNeto { get; set; }

    public decimal? PesoCono { get; set; }
}
