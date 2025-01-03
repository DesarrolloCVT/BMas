using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwDireccionesClientesSap
{
    public string CodDireccion { get; set; } = null!;

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string CardCode { get; set; } = null!;

    public string AdresType { get; set; } = null!;

    public string? Direccioncompleta { get; set; }
}
