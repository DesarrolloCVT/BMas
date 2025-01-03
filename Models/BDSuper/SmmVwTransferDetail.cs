using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwTransferDetail
{
    public int TransferId { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
