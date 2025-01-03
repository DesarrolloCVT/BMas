using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AccSucursal
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? USucNombre { get; set; }

    public string? USucCodigo { get; set; }

    public string? USucDir { get; set; }

    public string? USucComuna { get; set; }

    public string? USucCiudad { get; set; }
}
