using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uwko1
{
    public int OrderNum { get; set; }

    public int LineId { get; set; }

    public string? ItemCode { get; set; }

    public string? Descript { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public string? WhsCode { get; set; }

    public int? FinncPriod { get; set; }

    public string? ActWorkCod { get; set; }

    public decimal? ActWorkSum { get; set; }

    public int? ProdUpgNum { get; set; }
}
