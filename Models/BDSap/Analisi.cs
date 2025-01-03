using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Analisi
{
    public int? IntrnMatch { get; set; }

    public DateTime? MthDate { get; set; }

    public string? TransType { get; set; }

    public int? FolioNum { get; set; }

    public string? FolioPref { get; set; }

    public DateTime? Refdate { get; set; }

    public DateTime? Taxdate { get; set; }

    public int TransId { get; set; }

    public string? Account { get; set; }

    public string? Memo { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? LocTotal { get; set; }

    public string? BaseRef { get; set; }

    public int? Createdby { get; set; }

    public string CardCode { get; set; } = null!;

    public string? LicTradNum { get; set; }

    public string? CardName { get; set; }

    public string? ULibro { get; set; }

    public int Bplid { get; set; }
}
