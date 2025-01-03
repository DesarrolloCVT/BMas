using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ozrd
{
    public int AbsEntry { get; set; }

    public DateTime? DocDate { get; set; }

    public string? PosequipNo { get; set; }

    public int? ResetCntr { get; set; }

    public int? SummaryCnt { get; set; }

    public int? OperCntr { get; set; }

    public decimal? TotalSum { get; set; }

    public decimal? GrossSale { get; set; }

    public decimal? Pissum { get; set; }

    public decimal? Cofinssum { get; set; }
}
