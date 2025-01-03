using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfVideoVigilancium
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public string? Tipo { get; set; }

    public string? Modelo { get; set; }

    public int? Marca { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public string? Acceso { get; set; }

    public string? DirecciónMac { get; set; }

    public string? Firmware { get; set; }

    public string? Resolución { get; set; }

    public string? Nvr { get; set; }

    public string? ConectadaA { get; set; }

    public string? Monitoreo { get; set; }

    public string? Almacenamiento { get; set; }

    public string? Codificacion { get; set; }

    public int? Estado { get; set; }
}
