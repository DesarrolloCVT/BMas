using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Srt2
{
    public string SumRptId { get; set; } = null!;

    public int SeqNo { get; set; }

    public string? VatregNum { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public int? TransNo { get; set; }

    public decimal? BaseAmt { get; set; }

    public decimal? TaxAmt { get; set; }

    public string? Remark { get; set; }
}
