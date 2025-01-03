using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odim
{
    public short DimCode { get; set; }

    public string? DimName { get; set; }

    public string? DimActive { get; set; }

    public string? DimDesc { get; set; }
}
