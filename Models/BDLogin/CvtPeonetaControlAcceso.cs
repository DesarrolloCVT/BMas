using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPeonetaControlAcceso
{
    public int PeonetaId { get; set; }

    public int? ControlAccesoId { get; set; }

    public string? Run { get; set; }

    public string? Nombre { get; set; }

    public string? Observacion { get; set; }
}
