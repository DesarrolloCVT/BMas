using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetalleNoConformidad
{
    public int IdDetalleNoConformidad { get; set; }

    public int IdNoConformidad { get; set; }

    public string Origen { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CausaOrigen { get; set; }

    public string? DescAccionInmediata { get; set; }

    public DateTime? FechPlazoAccionInmediata { get; set; }

    public bool? CumpleAccioninmediata { get; set; }

    public string? DescAccionCorrectiva { get; set; }

    public DateTime? FechPlazoAccionCorrectiva { get; set; }

    public bool? CumpleAccionCorrectiva { get; set; }

    public string? DecSupervisionEjecucion { get; set; }

    public DateTime? FechSupervisionEjecucion { get; set; }

    public string? DecEficaciaAccion { get; set; }

    public bool? CumpleEficaciaAccion { get; set; }

    public DateTime? FechEvaluacionEficaciaAccion { get; set; }
}
