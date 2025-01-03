using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwCuentasCliente
{
    public string Empresa { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int DocEntry { get; set; }

    public int? NumDoc { get; set; }

    public int? FolioDoc { get; set; }

    public short? CodGrupProveedor { get; set; }

    public string GrupProveedor { get; set; } = null!;

    public string CodProveedor { get; set; } = null!;

    public string? Proveedor { get; set; }

    public decimal? LineaCredito { get; set; }

    public int SlpCode { get; set; }

    public string Vendedor { get; set; } = null!;

    public DateTime? FechaCon { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? SemanaVenc { get; set; }

    public int? MesVenc { get; set; }

    public int? AñoVenc { get; set; }

    public string? Moneda { get; set; }

    public decimal? Total { get; set; }

    public decimal? Abonos { get; set; }

    public decimal? Pendiente { get; set; }

    public string? LineaCreditoUf { get; set; }

    public decimal? LineaCreditoPesos { get; set; }

    public decimal? Uf { get; set; }

    public decimal? SeguroFecha { get; set; }
}
