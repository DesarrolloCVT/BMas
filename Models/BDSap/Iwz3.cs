using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Iwz3
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public string WhCode { get; set; } = null!;

    public decimal? RevalPrice { get; set; }

    public string? BaseCurr { get; set; }

    public DateTime? RevalDate { get; set; }

    public decimal? RevalSum { get; set; }

    public decimal? BasePrice { get; set; }

    public string? RealAcct { get; set; }

    public string? RevalOfsac { get; set; }

    public string? RevalType { get; set; }

    public string? ExeLine { get; set; }

    public string? RevCancel { get; set; }

    public DateTime? RvCaclDate { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? BalanceBef { get; set; }
}
