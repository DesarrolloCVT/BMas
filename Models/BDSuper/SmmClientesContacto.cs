using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmClientesContacto
{
    public int Idcontacto { get; set; }

    public string? CodCliente { get; set; }

    public string? Cargo { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Telefono1 { get; set; }

    public int? Telefono2 { get; set; }

    public string? Email { get; set; }
}
