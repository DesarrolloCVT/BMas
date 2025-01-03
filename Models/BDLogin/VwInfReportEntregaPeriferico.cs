using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwInfReportEntregaPeriferico
{
    public int IdEntPeriferico { get; set; }

    public string? FechaEntrega { get; set; }

    public string? RunUser { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Cargo { get; set; }

    public int? Cantidad { get; set; }

    public string TipoEntrega { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Comentarios { get; set; }
}
