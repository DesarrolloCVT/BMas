using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofbt
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public byte[]? Content { get; set; }

    public short? Isdefault { get; set; }

    public string? Botype { get; set; }

    public string? Doctype { get; set; }

    public string? Tempformat { get; set; }
}
