using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmListaSucursalesGetSucursale
{
    public string? FechaActualizacion { get; set; }

    public string CodCliente { get; set; } = null!;

    public string CodInterno { get; set; } = null!;

    public string? Ean { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Comuna { get; set; }
}
