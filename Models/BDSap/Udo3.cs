using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udo3
{
    public string Code { get; set; } = null!;

    public int ColumnNum { get; set; }

    public int SonNum { get; set; }

    public string? ColAlias { get; set; }

    public string? ColDesc { get; set; }

    public string? ColEdit { get; set; }
}
