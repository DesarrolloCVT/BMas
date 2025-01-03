using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ccadet
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCode { get; set; }

    public string? UCardcode { get; set; }

    public string? UCardtype { get; set; }
}
