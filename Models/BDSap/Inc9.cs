using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Inc9
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int CounterNum { get; set; }

    public decimal? TotalQty { get; set; }

    public int? LogIns { get; set; }
}
