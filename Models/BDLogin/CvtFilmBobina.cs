using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmBobina
{
    public int Nbobina { get; set; }

    public int? FolioRecepFilm { get; set; }

    public string? Producto { get; set; }

    public string? LoteInterno { get; set; }

    public string? LoteProveedor { get; set; }

    public DateTime? FechaProduc { get; set; }

    public DateTime? FechaVenc { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoCono { get; set; }

    public decimal? PesoNeto { get; set; }

    public int? EstadoBobina { get; set; }

    public decimal? PesoBrutoInicial { get; set; }

    public decimal? ReserveQuantity { get; set; }

    public int? IdBodega { get; set; }

    public DateTime? FechaBajada { get; set; }

    public string? CardCode { get; set; }

    public decimal? PesoNetoInicial { get; set; }
}
