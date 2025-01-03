using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Fct1
{
    public int AbsId { get; set; }

    public int? LineId { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public decimal? Quantity { get; set; }

    public string WhsCode { get; set; } = null!;
}
