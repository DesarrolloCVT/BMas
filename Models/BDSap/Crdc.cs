using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Crdc
{
    public string CardCode { get; set; } = null!;

    public int CommMeanId { get; set; }

    public string? Select { get; set; }
}
