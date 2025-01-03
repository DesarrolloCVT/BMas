using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sfi22
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int StdCostNum { get; set; }

    public decimal? Price { get; set; }

    public decimal? Total { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }
}
