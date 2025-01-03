using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLaboresTurnoRecepcione
{
    public int IdDetalleRecepciones { get; set; }

    public int IdLaborTurno { get; set; }

    public int? Oc { get; set; }

    public int? Guia { get; set; }

    public int? Nrecepcion { get; set; }

    public string? Ubicacion { get; set; }

    public string? Observaciones { get; set; }

    public string? Productos { get; set; }
}
