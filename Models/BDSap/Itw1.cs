using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Itw1
{
    public string ItemCode { get; set; } = null!;

    public string WhsCode { get; set; } = null!;

    public short? UserSign { get; set; }

    public short? CycleCode { get; set; }

    public string? Alert { get; set; }

    public DateTime? NextDate { get; set; }

    public short? Time { get; set; }

    public short? DestUser { get; set; }

    public string? Alerted { get; set; }

    public int BinAbs { get; set; }
}
