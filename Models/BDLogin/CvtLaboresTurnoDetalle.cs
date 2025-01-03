using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLaboresTurnoDetalle
{
    public int IdLabores { get; set; }

    public int? IdLaborTurno { get; set; }

    public string? Observacion { get; set; }

    public string? Novedades { get; set; }

    public int? Tipo { get; set; }
}
