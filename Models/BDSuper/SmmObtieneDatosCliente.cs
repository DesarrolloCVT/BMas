using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmObtieneDatosCliente
{
    public string Rut { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Codigo { get; set; }

    public string? RazonSocial { get; set; }

    public int? GrupoCliente { get; set; }

    public string? Giro { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
