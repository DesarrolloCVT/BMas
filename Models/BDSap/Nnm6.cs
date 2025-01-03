using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nnm6
{
    public string ObjectCode { get; set; } = null!;

    public string PeriodType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? Sequence { get; set; }

    public string? FormatStr { get; set; }
}
