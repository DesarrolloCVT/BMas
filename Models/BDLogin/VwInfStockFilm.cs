using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwInfStockFilm
{
    public int Nbobina { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoCono { get; set; }

    public decimal? PesoNeto { get; set; }

    public string? LoteInterno { get; set; }

    public string? BodegaActual { get; set; }

    public string? Proveedor { get; set; }

    public string? CodProveedor { get; set; }

    public string? LoteProveedor { get; set; }

    public DateTime? FechaProduc { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? FolioRecepFilm { get; set; }

    public DateTime? FechaRecep { get; set; }

    public int? NumeroDocSap { get; set; }

    public string? BodegaRecepcion { get; set; }
}
