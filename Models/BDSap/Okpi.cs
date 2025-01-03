using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Okpi
{
    public int AbsEntry { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Desc { get; set; }

    public string? ValueType { get; set; }

    public int? ValueQid { get; set; }

    public string? ViewName { get; set; }

    public string? ViewCtg { get; set; }

    public string? ViewSyn { get; set; }

    public string? TrendType { get; set; }

    public int? TrendQid { get; set; }

    public decimal? GoalValue { get; set; }

    public string? GoalQid { get; set; }

    public string? GoalDesc { get; set; }

    public string? CalcFrml { get; set; }

    public string? Visible { get; set; }

    public string? Sbetter { get; set; }

    public string? Author { get; set; }

    public string? Version { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? IsSystem { get; set; }

    public string? MeasUnit { get; set; }

    public string? RevSign { get; set; }

    public string? Unit { get; set; }
}
