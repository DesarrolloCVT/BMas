using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Msn3
{
    public int AbsEntry { get; set; }

    public string? ItemCode { get; set; }

    public int? PeriodId { get; set; }

    public decimal? Quantity { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? BaseObj { get; set; }

    public string? BaseDocNum { get; set; }

    public DateTime? BaseDue { get; set; }

    public string? StockType { get; set; }

    public int LineId { get; set; }

    public string? ParentCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? WhsCode { get; set; }
}
