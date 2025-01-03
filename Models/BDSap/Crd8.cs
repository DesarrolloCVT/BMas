using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Crd8
{
    public string CardCode { get; set; } = null!;

    public int Bplid { get; set; }

    public string? DisabledBp { get; set; }
}
