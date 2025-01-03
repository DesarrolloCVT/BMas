using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCobranzaCvtBma
{
    public string Empresa { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int? FolioDoc { get; set; }

    public string GrupProveedor { get; set; } = null!;

    public string CodProveedor { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string? GrpEmpresa { get; set; }

    public string Vendedor { get; set; } = null!;

    public DateTime? FechaCon { get; set; }

    public DateTime? FechaVenc { get; set; }

    public decimal? Total { get; set; }

    public decimal? Abonos { get; set; }

    public decimal? Pendiente { get; set; }

    public string LineaCreditoUf { get; set; } = null!;

    public decimal? Uf { get; set; }

    public decimal SeguroFecha { get; set; }

    public string? DocRelacionado { get; set; }

    public string? Oc { get; set; }

    public string CondicionPago { get; set; } = null!;

    public string? GrupoVenta { get; set; }

    public string? Comuna { get; set; }

    public string? Ciudad { get; set; }

    public string? NumRegion { get; set; }

    public string? Estado { get; set; }

    public string? ListaNegra { get; set; }

    public int? DiasVencidos { get; set; }

    public string? GrupoVencimiento { get; set; }

    public decimal? Nota { get; set; }

    public string? ComunaPbi { get; set; }

    public string? CiudadPbi { get; set; }
}
