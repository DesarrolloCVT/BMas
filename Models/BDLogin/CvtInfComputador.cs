using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfComputador
{
    public int Id { get; set; }

    public string? NombreEquipo { get; set; }

    public string? Dispositivo { get; set; }

    public string? DireccionIp { get; set; }

    public string? DireccionMac { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Ram { get; set; }

    public string? Procesador { get; set; }

    public string? Disco { get; set; }

    public int SistemaOperativo { get; set; }

    public int? AreaUOficina { get; set; }

    public int? IdUsuario { get; set; }

    public string? CodAf { get; set; }

    public string? CodLicencia { get; set; }

    public int? Estado { get; set; }
}
