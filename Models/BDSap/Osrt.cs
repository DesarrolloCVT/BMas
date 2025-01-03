using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osrt
{
    public int AbsId { get; set; }

    public string SumRptId { get; set; } = null!;

    public DateTime? SumRptDate { get; set; }

    public int? Bplid { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? RptType { get; set; }

    public string? Version { get; set; }

    public string? SumSubId { get; set; }

    public string? SumRptType { get; set; }
}
