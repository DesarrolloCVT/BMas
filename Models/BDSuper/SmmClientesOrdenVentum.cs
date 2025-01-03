using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmClientesOrdenVentum
{
    public string RutCliente { get; set; } = null!;

    public string? NombreCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? Giro { get; set; }

    public string? DirecFact { get; set; }

    public string? DirecDesp { get; set; }

    public string? Telefono { get; set; }

    public string Correo { get; set; } = null!;

    public int? Estado { get; set; }

    public string? UbiLatitud { get; set; }

    public string? UbiLongitud { get; set; }

    public string? UbiAltitud { get; set; }
}
