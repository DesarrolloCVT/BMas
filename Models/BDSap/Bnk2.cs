using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bnk2
{
    public int IdNumber { get; set; }

    public int Bsline { get; set; }

    public short ListLineId { get; set; }

    public string? DocId { get; set; }

    public short? DocType { get; set; }

    public decimal? AmntLc { get; set; }

    public decimal? AmntFc { get; set; }

    public string? IsDebit { get; set; }

    public string? Glact { get; set; }

    public string? PrftCenter { get; set; }

    public string? Project { get; set; }

    public string? VatCode { get; set; }

    public string? Selected { get; set; }

    public decimal? VatLc { get; set; }

    public decimal? VatFc { get; set; }

    public int? Installmnt { get; set; }

    public string? InterimAct { get; set; }

    public int? JdtLine { get; set; }

    public int? DocNum { get; set; }

    public string? PrftCent2 { get; set; }

    public string? PrftCent3 { get; set; }

    public string? PrftCent4 { get; set; }

    public string? PrftCent5 { get; set; }

    public string? MatchLog { get; set; }

    public decimal? DueBal { get; set; }

    public decimal? DueBalFc { get; set; }

    public decimal? AmntSc { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }
}
