using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfTelefoniaFija
{
    public int IdTfija { get; set; }

    public int VlanId { get; set; }

    public string Dispositivo { get; set; } = null!;

    public string? Oficina { get; set; }

    public string? Usuario { get; set; }

    public int? Anexo { get; set; }

    public string DireccionIp { get; set; } = null!;

    public string DireccionMac { get; set; } = null!;

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Otros { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
