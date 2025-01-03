using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ncp2
{
    public int PageEntry { get; set; }

    public string? Type { get; set; }

    public int ObjectType { get; set; }

    public string ObjectKey { get; set; } = null!;
}
