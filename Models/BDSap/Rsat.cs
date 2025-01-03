using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rsat
{
    public int QueryId { get; set; }

    public int? QueryDate { get; set; }

    public int? QueryTime { get; set; }

    public string? QueryDetls { get; set; }
}
