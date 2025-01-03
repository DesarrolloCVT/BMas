using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gfl2
{
    public string FormId { get; set; } = null!;

    public string GridId { get; set; } = null!;

    public short UserCode { get; set; }

    public int FilterId { get; set; }

    public string? Name { get; set; }
}
