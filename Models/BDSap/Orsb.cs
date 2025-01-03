using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orsb
{
    public short ResGrpCod { get; set; }

    public string ResGrpNam { get; set; } = null!;

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Object { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ResType { get; set; }

    public string? CostName1 { get; set; }

    public decimal? CostVal1 { get; set; }

    public string? CostName2 { get; set; }

    public decimal? CostVal2 { get; set; }

    public string? CostName3 { get; set; }

    public decimal? CostVal3 { get; set; }

    public string? CostName4 { get; set; }

    public decimal? CostVal4 { get; set; }

    public string? CostName5 { get; set; }

    public decimal? CostVal5 { get; set; }

    public string? CostName6 { get; set; }

    public decimal? CostVal6 { get; set; }

    public string? CostName7 { get; set; }

    public decimal? CostVal7 { get; set; }

    public string? CostName8 { get; set; }

    public decimal? CostVal8 { get; set; }

    public string? CostName9 { get; set; }

    public decimal? CostVal9 { get; set; }

    public string? CostName10 { get; set; }

    public decimal? CostVal10 { get; set; }

    public string? ResUoM { get; set; }
}
