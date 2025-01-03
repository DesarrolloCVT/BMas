using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAcuerdoComercialDetalle
{
    public int IdDetAcuerdoComercial { get; set; }

    public int? IdAcuerdoComercial { get; set; }

    public string? CodProducto { get; set; }

    public decimal? SellInt { get; set; }

    public decimal? SellOut { get; set; }

    public decimal? Rapel { get; set; }

    public decimal? Merma { get; set; }

    public decimal? Retiro { get; set; }

    public decimal? Centralizado { get; set; }

    public decimal? ProntoPago { get; set; }

    public decimal? TotalAcuerdo { get; set; }

    public DateTime? FechDesde { get; set; }

    public DateTime? FechHasta { get; set; }

    public int? AporteFijo { get; set; }
}
