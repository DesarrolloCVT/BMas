using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1MarketingDocumentsViewAr
{
    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public int? DocNum { get; set; }

    public string? LicTradNum { get; set; }

    public int? Series { get; set; }

    public string? Canceled { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public string IsDraft { get; set; } = null!;

    public int? Bplid { get; set; }

    public int? FolNumFrom { get; set; }

    public int? FolNumTo { get; set; }

    public string? Pticode { get; set; }

    public string? Letter { get; set; }

    public int? EdocExpFrm { get; set; }

    public int DocEntry { get; set; }

    public string? ObjType { get; set; }

    public int? FolSeries { get; set; }
}
