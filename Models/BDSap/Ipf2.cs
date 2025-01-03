using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ipf2
{
    public int DocEntry { get; set; }

    public int? LineNum { get; set; }

    public string AlcCode { get; set; } = null!;

    public string? OhType { get; set; }

    public decimal? CostSum { get; set; }

    public decimal? CostSumFc { get; set; }

    public decimal? Factor { get; set; }

    public string CostType { get; set; } = null!;

    public string? Locked { get; set; }

    public string? LaCallcAcc { get; set; }

    public decimal? CostSumSc { get; set; }

    public string? InCustCalc { get; set; }

    public decimal? OpenCost { get; set; }

    public decimal? OpenCostFc { get; set; }

    public decimal? OpenCostSc { get; set; }

    public string? AgentCode { get; set; }

    public string? AgentName { get; set; }

    public string? CostCateg { get; set; }

    public string? EncryptIv { get; set; }
}
