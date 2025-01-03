using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awo3
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int LayerId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? RtoStock { get; set; }

    public decimal? RtoStockSc { get; set; }

    public string? WhsCode { get; set; }

    public int? IvltransSe { get; set; }

    public int? IvllayerId { get; set; }

    public int? SnbSysNum { get; set; }

    public int? SnbAbsEnt { get; set; }

    public int LogInstanc { get; set; }

    public int? InmsubLine { get; set; }
}
