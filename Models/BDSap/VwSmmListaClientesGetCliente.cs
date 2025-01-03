using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmListaClientesGetCliente
{
    public string? FechaActualizacion { get; set; }

    public string? Rut { get; set; }

    public string CodInterno { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string? EMail { get; set; }

    public string? Telefono { get; set; }

    public string? CondicionPago { get; set; }

    public decimal? LineaCredito { get; set; }

    public int? SlpCode { get; set; }

    public string? Vendedor { get; set; }
}
