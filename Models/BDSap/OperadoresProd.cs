using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class OperadoresProd
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCodOperador { get; set; }

    public string? UNomOperador { get; set; }
}
