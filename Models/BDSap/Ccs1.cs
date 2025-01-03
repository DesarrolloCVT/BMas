using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ccs1
{
    public string WhsCode { get; set; } = null!;

    public int Entry { get; set; }

    public short? CycleCode { get; set; }

    public string? Alert { get; set; }

    public short? DestUser { get; set; }

    public DateTime? NextDate { get; set; }

    public short? Time { get; set; }

    public string? ExcldZrQty { get; set; }

    public string? Alerted { get; set; }

    public string? ChangExist { get; set; }
}
