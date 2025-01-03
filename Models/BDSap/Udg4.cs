using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udg4
{
    public string Code { get; set; } = null!;

    public int Fndabs { get; set; }

    public string? ObjectCode { get; set; }

    public string? DocSubtype { get; set; }

    public string? DflPticode { get; set; }

    public string? DflPtiFce { get; set; }
}
