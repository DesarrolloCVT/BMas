using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwExpeditiondetailexport
{
    public int ExpeditionId { get; set; }

    public string PackageSscc { get; set; } = null!;

    public string? PackageLot { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? ExpeditionDetailQuantity { get; set; }

    public string? UomCode { get; set; }

    public int? BaseUnMed { get; set; }

    public decimal? CantUniTot { get; set; }
}
