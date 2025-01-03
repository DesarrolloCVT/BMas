using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bal1
{
    public int AbsEntry { get; set; }

    public int Instance { get; set; }

    public DateTime? Obdate { get; set; }

    public decimal? InAmount { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? InAmntLwa { get; set; }

    public decimal? InQtyLwa { get; set; }

    public int? LastTrnsId { get; set; }

    public string? WasPrevOb { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public decimal? CrossPrev { get; set; }

    public string? WasUpdPrCb { get; set; }
}
