using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Icd2
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int ChildNum { get; set; }

    public string BarCode { get; set; } = null!;

    public string UomCode { get; set; } = null!;

    public decimal? UomQty { get; set; }

    public decimal? CountQty { get; set; }

    public decimal? Tk1UomQty { get; set; }

    public decimal? Tk2UomQty { get; set; }

    public decimal? Tk1CntQty { get; set; }

    public decimal? Tk2CntQty { get; set; }

    public decimal? ItmsPerUnt { get; set; }

    public int? LogIns { get; set; }

    public int? UgpEntry { get; set; }

    public decimal? TeamUomQty { get; set; }

    public decimal? TeamCntQty { get; set; }

    public string? IuomEntry { get; set; }
}
