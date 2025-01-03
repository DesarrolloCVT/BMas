using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwExpedicionDetalle
{
    public int ExpeditionId { get; set; }

    public string? SiteDescription { get; set; }

    public int? ExpeditionMotivo { get; set; }

    public string? SaleCostAc { get; set; }

    public decimal? AvgPrice { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
