using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmClientesDireccion
{
    public string CodCliente { get; set; } = null!;

    public int CodDireccion { get; set; }

    public string? Direccion { get; set; }

    public int? Region { get; set; }

    public string? Ciudad { get; set; }

    public string? Comuna { get; set; }

    public string? TipoDir { get; set; }
}
