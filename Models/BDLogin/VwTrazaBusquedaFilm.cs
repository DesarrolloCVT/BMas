using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwTrazaBusquedaFilm
{
    public int Nbobina { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoNeto { get; set; }

    public decimal? ReserveQuantity { get; set; }

    public string? LoteInterno { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string EstadoBobina { get; set; } = null!;

    public DateTime? FechaRecep { get; set; }

    public string? BodActual { get; set; }

    public DateTime? FechaProduc { get; set; }

    public DateTime? FechaVenc { get; set; }

    public string? LoteProveedor { get; set; }
}
