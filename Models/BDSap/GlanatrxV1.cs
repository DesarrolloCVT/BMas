using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class GlanatrxV1
{
    public int? IntrnMatch { get; set; }

    public DateTime? MthDate { get; set; }

    public string? TransType { get; set; }

    public int? FolioNum { get; set; }

    public string? FolioPref { get; set; }

    public DateTime? Refdate { get; set; }

    public DateTime? Taxdate { get; set; }

    public DateTime? Duedate { get; set; }

    public int TransId { get; set; }

    public string? Account { get; set; }

    public string? FormatCode { get; set; }

    public string? Acctname { get; set; }

    public string? Memo { get; set; }

    public decimal? MontoDoc { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? Systotal { get; set; }

    public decimal? Fctotal { get; set; }

    public string? Fccurrency { get; set; }

    public string? BaseRef { get; set; }

    public int? Createdby { get; set; }

    public string? CardCode { get; set; }

    public string? LicTradNum { get; set; }

    public string? CardName { get; set; }

    public decimal? BalDueDeb { get; set; }

    public decimal? BalDueCred { get; set; }

    public decimal? BalFcDeb { get; set; }

    public decimal? BalFcCred { get; set; }
}
