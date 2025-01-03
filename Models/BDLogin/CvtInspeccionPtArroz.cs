using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtArroz
{
    public int IdInspeccionPtArroz { get; set; }

    public string Lote { get; set; } = null!;

    public string? CardCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime? FechaRegisro { get; set; }

    public string? AccionCorrectiva { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public bool? Pmixto { get; set; }

    public string? ProvMixto { get; set; }

    public int? IdVerificador { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaVerificacion { get; set; }
}
