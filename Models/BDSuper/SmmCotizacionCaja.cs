using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmCotizacionCaja
{
    public int CotizacionId { get; set; }

    public string? NombreCliente { get; set; }

    public int? CantidadProducir { get; set; }

    public int? PrecioVenta { get; set; }

    public int? Estado { get; set; }

    public int? CosTotalCotizacion { get; set; }

    public decimal? MargenTotal { get; set; }

    public DateTime? FechaCotizacion { get; set; }

    public int? IdUsuario { get; set; }

    public string? CorreoCliente { get; set; }

    public string? FormaDePago { get; set; }
}
