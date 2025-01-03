using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwExcelListadoClientesSinDireccion
{
    public string Codigo { get; set; } = null!;

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string Grupo { get; set; } = null!;

    public string? GrupoVenta { get; set; }

    public string? Vendedor { get; set; }
}
