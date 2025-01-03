using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovrt
{
    public string TxInvRptNo { get; set; } = null!;

    public DateTime? TxInvRptDt { get; set; }

    public int? SupBplid { get; set; }

    public string? CardCode { get; set; }

    public decimal? BaseAmt { get; set; }

    public int? BlankNo { get; set; }

    public decimal? TaxAmt { get; set; }

    public decimal? Total { get; set; }

    public string? Bpaddress { get; set; }

    public string? Version { get; set; }

    public int? ReportType { get; set; }

    public string? Ntsapprov { get; set; }

    public short? NtswebSite { get; set; }

    public string? NtseTaxNo { get; set; }

    public string? NtsapprNo { get; set; }

    public string? Remarks { get; set; }

    public string? OriNtsappr { get; set; }

    public string? CardName { get; set; }

    public string? RptStatus { get; set; }

    public string? OriTaxInvN { get; set; }

    public string? TxInvPrint { get; set; }

    public string? Canceled { get; set; }
}
