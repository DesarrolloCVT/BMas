using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Icd10
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int ChildNum { get; set; }

    public int CounterNum { get; set; }

    public decimal? UomQty { get; set; }

    public decimal? InvtQty { get; set; }

    public int? LogIns { get; set; }
}
