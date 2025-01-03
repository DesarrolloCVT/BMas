using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class ExpeditionDetail
{
    public int SiteId { get; set; }

    public int ExpeditionId { get; set; }

    public int PackageId { get; set; }

    public int? IdUsuario { get; set; }

    public string PackageSscc { get; set; } = null!;

    public decimal? ExpeditionDetailQuantity { get; set; }

    public DateTime? ExpeditionDetailConfirmedDate { get; set; }
}
