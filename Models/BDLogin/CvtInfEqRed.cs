using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEqRed
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public string? Ip { get; set; }

    public string? Mac { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Velocidad { get; set; }

    public string? Puertos { get; set; }

    public string? Sfp { get; set; }

    public string? Firmware { get; set; }

    public string? Ubicación { get; set; }

    public string? Gateway { get; set; }

    public string? MascaraSubred { get; set; }

    public string? IpPublica { get; set; }

    public string? Dns { get; set; }

    public DateTime? FechaCompra { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
