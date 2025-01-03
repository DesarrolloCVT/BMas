using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Package
{
    public int PackageId { get; set; }

    public int? ReceptionId { get; set; }

    public int? LayoutId { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? PackageQuantityInitial { get; set; }

    public decimal? PackageQuantity { get; set; }

    public int? PackageStatus { get; set; }

    public string? PackageSscc { get; set; }

    public string? PackageLot { get; set; }

    public DateTime? PackageProductionDate { get; set; }

    public DateTime? PackageExpiresDate { get; set; }

    public DateTime? PackageInDate { get; set; }

    public DateTime? PackageOutDate { get; set; }

    public string? PackageSn { get; set; }

    public decimal? PackageReserveQuantity { get; set; }

    public string? PackageData1 { get; set; }

    public string? PackageData2 { get; set; }

    public int? Linea { get; set; }

    public string? UnMedida { get; set; }

    public int? BaseUnMed { get; set; }

    public int? UgpEntry { get; set; }

    public int? UomEntry { get; set; }

    public string? UomCode { get; set; }

    public decimal? CantUniTot { get; set; }
}
