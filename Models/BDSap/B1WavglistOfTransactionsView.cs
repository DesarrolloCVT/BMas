using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1WavglistOfTransactionsView
{
    public int MessageId { get; set; }

    public string? ItemCode { get; set; }

    public int? TransType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLineNum { get; set; }

    public int? BaseType { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseLine { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? DocPrice { get; set; }

    public decimal? Price { get; set; }

    public string? PriceCurr { get; set; }

    public decimal? TotalLc { get; set; }

    public decimal? TotalFc { get; set; }

    public decimal? TotalSc { get; set; }

    public decimal? DocTotal { get; set; }

    public string? Currency { get; set; }

    public decimal? DocRate { get; set; }

    public string? LocCode { get; set; }

    public string? BpcardCode { get; set; }

    public string? PrjCode { get; set; }

    public int? AccumType { get; set; }

    public int? ActionType { get; set; }

    public DateTime? SystemDate { get; set; }

    public DateTime? EffectivePostingDate { get; set; }

    public DateTime? PostingDate { get; set; }

    public int? DocNum { get; set; }

    public string? IsCrin { get; set; }

    public int? ApplObj { get; set; }

    public int? AppObjAbs { get; set; }

    public int? AppObjLine { get; set; }

    public short? ItmsGrpCod { get; set; }

    public string? TaxOnly { get; set; }
}
