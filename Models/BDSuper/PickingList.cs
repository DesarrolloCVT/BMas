using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class PickingList
{
    public int SiteId { get; set; }

    public int PickingListId { get; set; }

    public DateTime? PickingListDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal PickingListQuantity { get; set; }

    public int? PackageIdOrigin { get; set; }

    public string? PackageSsccOrigin { get; set; }

    public int? PackageIdDestiny { get; set; }

    public string? PackageSsccDestiny { get; set; }

    public int? IdUsuario { get; set; }
}
