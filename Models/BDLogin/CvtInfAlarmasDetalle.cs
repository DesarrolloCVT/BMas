using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfAlarmasDetalle
{
    public int IdDetAlarma { get; set; }

    public string? NombreSensor { get; set; }

    public int? TipoSensor { get; set; }

    public string? LugarUbicacion { get; set; }

    public int? IdContrato { get; set; }
}
