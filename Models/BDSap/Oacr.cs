using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oacr
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? PostingAct { get; set; }

    public string? CalcAcct { get; set; }

    public string? InterimAct { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
