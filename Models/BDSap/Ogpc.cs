using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogpc
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? StateTax { get; set; }

    public string? Prdcity { get; set; }

    public int? Spedctgory { get; set; }
}
