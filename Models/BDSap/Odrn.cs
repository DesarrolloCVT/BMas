using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odrn
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? Series { get; set; }

    public string? DprArea { get; set; }

    public string? Status { get; set; }

    public string? Canceled { get; set; }

    public DateTime? RefDate { get; set; }

    public string? PeriodCat { get; set; }

    public int? PostPeriod { get; set; }

    public DateTime? KeyDate { get; set; }

    public string? Remarks { get; set; }

    public int? NumOfJes { get; set; }

    public decimal? SumOfDpr { get; set; }

    public string? SumByPro { get; set; }

    public string? SumByDistr { get; set; }

    public string? TransType { get; set; }

    public int? TransAbs { get; set; }
}
