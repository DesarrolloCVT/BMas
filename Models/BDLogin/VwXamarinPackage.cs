using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwXamarinPackage
{
    public int CompanyId { get; set; }

    public int PackageId { get; set; }

    public int SupportiveId { get; set; }

    public int? ReceptionId { get; set; }

    public int? LayoutId { get; set; }

    public int ArticleProviderId { get; set; }

    public decimal ArticleProviderGrossWeight { get; set; }

    public string? PackageBarcode { get; set; }

    public int PackageQuantityInitial { get; set; }

    public int PackageQuantity { get; set; }

    public decimal? PackageNetWeightInitial { get; set; }

    public decimal? PackageNetWeight { get; set; }

    public decimal? PackageGrossWeightInitial { get; set; }

    public decimal? PackageGrossWeight { get; set; }

    public decimal? PackageHeight { get; set; }

    public int? PackageStatus { get; set; }

    public int? PackageQualityStatus { get; set; }

    public string PackageOwner { get; set; } = null!;

    public string? PackageSscc { get; set; }

    public string? PackageSsccparent { get; set; }

    public int? PackageSsccparentId { get; set; }

    public string? PackageLot { get; set; }

    public DateTime PackageProductionDate { get; set; }

    public DateTime PackageExpiresDate { get; set; }

    public int? PackageMixed { get; set; }

    public DateTime PackageInDate { get; set; }

    public DateTime? PackageOutDate { get; set; }

    public string? PackageSn { get; set; }

    public string? PackagePn { get; set; }

    public int? PackageReserveQuantity { get; set; }

    public int? PackageReserve { get; set; }

    public string? PackageData1 { get; set; }

    public string? PackageData2 { get; set; }

    public int? PackageStateId { get; set; }

    public int? AccountsId { get; set; }

    public string? PackageFoilPp { get; set; }

    public int? EntryType { get; set; }

    public int PackageOrigin { get; set; }

    public int PackageDestination { get; set; }

    public int? PackageDependencesTotal { get; set; }

    public int? PackageCrossDocking { get; set; }

    public int? PackageStateIdInitial { get; set; }

    public string? DevolucionMotivoId { get; set; }
}
