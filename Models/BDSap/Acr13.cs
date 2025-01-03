using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acr13
{
    public string CardCode { get; set; } = null!;

    public string CurrCode { get; set; } = null!;

    public string? Include { get; set; }

    public string? Locked { get; set; }

    public int LogInstanc { get; set; }
}
