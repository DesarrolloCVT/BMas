using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SboFelectDetalle
{
    public int DocEntry { get; set; }

    public string? ObjType { get; set; }

    public decimal? LineNum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? LocalPrice { get; set; }

    public decimal? PrecioBoleta { get; set; }

    public string? UnitMsr { get; set; }

    public string Moneda { get; set; } = null!;

    public decimal? Kilogramos { get; set; }

    public string Reserva1 { get; set; } = null!;

    public string Reserva2 { get; set; } = null!;

    public decimal? LineTotal { get; set; }

    public decimal? TotalBoleta { get; set; }

    public string LineTotalUsd { get; set; } = null!;

    public string Almacen { get; set; } = null!;

    public string? Iexen { get; set; }

    public int MontoDesc { get; set; }

    public string? Dscription { get; set; }
}
