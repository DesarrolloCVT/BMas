using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfOtroEq
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public string? Proveedor { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? DireccionIp { get; set; }

    public string? Mac { get; set; }

    public string? BaseDatos { get; set; }

    public string? UsuarioBd { get; set; }

    public string? ContraseñaBd { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
