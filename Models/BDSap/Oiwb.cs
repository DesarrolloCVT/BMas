using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oiwb
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public string WhsCode { get; set; } = null!;

    public decimal? Counted { get; set; }

    public string? WasCounted { get; set; }
}
