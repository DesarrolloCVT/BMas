using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEqWireless
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public string? UsuarioAdm { get; set; }

    public string? ContraseñaAdm { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Ip { get; set; }

    public string? Mac { get; set; }

    public string? Ubicación { get; set; }

    public string? SecurityType { get; set; }

    public string? Canal { get; set; }

    public string? Firmware { get; set; }

    public string? ConectadoA { get; set; }

    public string? Ssid { get; set; }

    public int? Clave { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
