using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfAlarma
{
    public int IdContrato { get; set; }

    public string UsuarioMaestro { get; set; } = null!;

    public string? Contrasena { get; set; }

    public string? CserviciosAdt { get; set; }

    public string? Monitoreo { get; set; }

    public int? CostoHabilitacion { get; set; }

    public int? CostoMensual { get; set; }

    public string? Tipo { get; set; }
}
