using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRendicionCosto
{
    public int IdRendi { get; set; }

    public string? RunSolicita { get; set; }

    public string? MotivoGasto { get; set; }

    public int? CentroCosto { get; set; }

    public int? TipoDocumento { get; set; }

    public string? Empresa { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdusuarioCrea { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? IdusuarioValida { get; set; }

    public DateTime? FechaValidacion { get; set; }

    public int? IdusuarioCierraRendi { get; set; }

    public DateTime? FechaCierreRendi { get; set; }

    public int? TotalRendicion { get; set; }
}
