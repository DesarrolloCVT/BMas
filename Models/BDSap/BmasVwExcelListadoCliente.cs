using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwExcelListadoCliente
{
    public string Codigo { get; set; } = null!;

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string Grupo { get; set; } = null!;

    public string? GrupoVenta { get; set; }

    public string? Vendedor { get; set; }

    public string? Calle { get; set; }

    public string? Comuna { get; set; }

    public string? Region { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Email { get; set; }
}
