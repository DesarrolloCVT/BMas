using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Valitemgastoxdim
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UDimension { get; set; }

    public string? UAccount { get; set; }

    public string? UItemCc { get; set; }
}
