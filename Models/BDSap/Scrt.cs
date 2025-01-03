using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scrt
{
    public string DocCode { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public int Language { get; set; }

    public string? String { get; set; }
}
