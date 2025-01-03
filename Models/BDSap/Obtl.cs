using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obtl
{
    public int AbsEntry { get; set; }

    public int? MessageId { get; set; }

    public int? BinAbs { get; set; }

    public int? SnBmdabs { get; set; }

    public decimal? Quantity { get; set; }

    public int? Itlentry { get; set; }
}
