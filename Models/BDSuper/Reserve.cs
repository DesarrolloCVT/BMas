using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Reserve
{
    public int ReserveId { get; set; }

    public int? PackageId { get; set; }

    public int? LayoutId { get; set; }

    public string? ItemCode { get; set; }

    public string? Lot { get; set; }

    public string? PackageSerie { get; set; }

    public int? WavePickingId { get; set; }

    public decimal? ReserveQuantity { get; set; }

    public int? ReserveStatus { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public DateOnly? InDate { get; set; }

    public DateTime? ReserveDate { get; set; }

    public int? IdUsuario { get; set; }

    public int? TransferId { get; set; }

    public int? TransferDetailUnitId { get; set; }
}
