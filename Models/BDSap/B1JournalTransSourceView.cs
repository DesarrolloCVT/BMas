using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1JournalTransSourceView
{
    public int DocEntry { get; set; }

    public int InstlmntId { get; set; }

    public string? ObjType { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? NumAtCard { get; set; }

    public int? SlpCode { get; set; }

    public decimal? InsTotal { get; set; }

    public decimal? InsTotalFc { get; set; }

    public decimal? InsTotalSy { get; set; }

    public string? BlockDunn { get; set; }

    public int? DunnLevel { get; set; }

    public string TransType { get; set; } = null!;

    public string IsSales { get; set; } = null!;

    public string IsDunnable { get; set; } = null!;

    public int? BoeNum { get; set; }

    public string? BoeStatus { get; set; }

    public string? PeyMethod { get; set; }
}
