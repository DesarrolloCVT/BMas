using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtListadoClientesPbi
{
    public string Codigo { get; set; } = null!;

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string Grupo { get; set; } = null!;

    public string? Eerr { get; set; }

    public string? GrupoVenta { get; set; }

    public string? Vendedor { get; set; }

    public string? Canal { get; set; }

    public string? SubCanal { get; set; }
}
