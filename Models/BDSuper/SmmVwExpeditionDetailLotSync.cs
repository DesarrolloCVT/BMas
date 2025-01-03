using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwExpeditionDetailLotSync
{
    public int ExpeditionId { get; set; }

    public string? PackageLot { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
