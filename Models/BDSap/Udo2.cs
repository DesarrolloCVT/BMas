using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udo2
{
    public string Code { get; set; } = null!;

    public int ColumnNum { get; set; }

    public string? ColAlias { get; set; }

    public string? ColumnDesc { get; set; }
}
