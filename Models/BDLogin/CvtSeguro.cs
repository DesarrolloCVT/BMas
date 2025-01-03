using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSeguro
{
    public string Poliza { get; set; } = null!;

    public string? Compania { get; set; }

    public int? IdTipoSeguro { get; set; }

    public int EmpresaAsegurada { get; set; }

    public decimal? PrimaAfecta { get; set; }

    public decimal? PrimaExenta { get; set; }

    public decimal? PrimaTotal { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? CantidadCuotas { get; set; }

    public string? Moneda { get; set; }
}
