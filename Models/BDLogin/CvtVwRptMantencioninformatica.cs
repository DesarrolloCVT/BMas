using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRptMantencioninformatica
{
    public int IdMantencion { get; set; }

    public DateTime FechaMantencion { get; set; }

    public string TipoMantencion { get; set; } = null!;

    public int Usuario { get; set; }

    public string? Falla { get; set; }

    public string? Causa { get; set; }

    public string? Solucion { get; set; }

    public string? Observacion { get; set; }

    public string CodActivo { get; set; } = null!;

    public string Mantencion { get; set; } = null!;

    public string? DetalleMantencion { get; set; }
}
