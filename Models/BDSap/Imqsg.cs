using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imqsg
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public int? Weight { get; set; }

    public DateTime? Time { get; set; }

    public string? Owner { get; set; }

    public int? Language { get; set; }
}
