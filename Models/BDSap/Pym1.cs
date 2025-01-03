using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pym1
{
    public string PymCode { get; set; } = null!;

    public string CurrCode { get; set; } = null!;

    public string? CurrName { get; set; }

    public string? Choose { get; set; }
}
