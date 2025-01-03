using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oter
{
    public int TerritryId { get; set; }

    public string? Descript { get; set; }

    public int Parent { get; set; }

    public int Lindex { get; set; }

    public string? Inactive { get; set; }
}
