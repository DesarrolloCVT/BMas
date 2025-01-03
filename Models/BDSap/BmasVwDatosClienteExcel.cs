using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwDatosClienteExcel
{
    public string Codigo { get; set; } = null!;

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string? NombreFantasia { get; set; }

    public string? Eerr { get; set; }

    public string? GrupoCliente { get; set; }

    public string? GrupoVenta { get; set; }

    public string Canal { get; set; } = null!;

    public string SubCanal { get; set; } = null!;

    public string? Vendedor { get; set; }

    public string? CondicionPago { get; set; }

    public string? LineaUf { get; set; }

    public decimal? LineaCreditoHoy { get; set; }

    public decimal? Pendiente { get; set; }

    public string Estado { get; set; } = null!;

    public string TipoInactividad { get; set; } = null!;

    public string? ComentariosInact { get; set; }
}
