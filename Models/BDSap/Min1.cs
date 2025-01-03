using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Min1
{
    public int? MinvNum { get; set; }

    public int AbsEntry { get; set; }

    public int? DocNum { get; set; }

    public string DocType { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public DateTime? DocClsDate { get; set; }

    public decimal? DocAmount { get; set; }

    public decimal? DocExpense { get; set; }

    public decimal? DocDiscSum { get; set; }

    public decimal? DocRound { get; set; }

    public decimal? DocTax { get; set; }

    public string? Closed { get; set; }

    public int? MinumWnCls { get; set; }

    public int Entry { get; set; }

    public string? DocOrigin { get; set; }
}
