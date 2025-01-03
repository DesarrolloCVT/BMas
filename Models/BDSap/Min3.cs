using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Min3
{
    public int Entry { get; set; }

    public string? TaxCode { get; set; }

    public decimal? VatPercent { get; set; }

    public string? CrditDebit { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? BaseSumSc { get; set; }

    public decimal? BaseSumFc { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumSc { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? TodedBaseS { get; set; }

    public decimal? TodedBaSsc { get; set; }

    public decimal? TodedBaSfc { get; set; }

    public int LnDataNum { get; set; }
}
