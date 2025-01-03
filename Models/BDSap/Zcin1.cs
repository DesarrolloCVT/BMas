using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zcin1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short? UYear { get; set; }

    public short? UMonth { get; set; }

    public string? UItemCode { get; set; }

    public string? UWh { get; set; }

    public decimal? UQty { get; set; }

    public decimal? UUnitCost { get; set; }

    public decimal? UBalance { get; set; }

    public string? UOrigin { get; set; }

    public int? UNRcpNo { get; set; }

    public DateTime? UNDate { get; set; }

    public string? UNCurrcy { get; set; }

    public decimal? UNQty { get; set; }

    public decimal? UNUniCst { get; set; }

    public decimal? UNPercnt { get; set; }

    public short? UNSituac { get; set; }

    public int? UFRcpNo { get; set; }

    public DateTime? UFDate { get; set; }

    public string? UFCurrcy { get; set; }

    public decimal? UFQty { get; set; }

    public decimal? UFUntCst { get; set; }

    public decimal? UFPercnt { get; set; }

    public short? UFSituac { get; set; }

    public decimal? UCUntCst { get; set; }

    public decimal? UCBalanc { get; set; }

    public decimal? UCAmount { get; set; }

    public string? UStatus { get; set; }

    public string? UVersionLl { get; set; }

    public short? UTrnsTypeN { get; set; }

    public short? UTrnsTypeI { get; set; }

    public int? UCreatedByN { get; set; }

    public int? UCreatedByI { get; set; }

    public int UBplid { get; set; }

    public string? UStockAct { get; set; }

    public string? UStockRvAct { get; set; }

    public string? UStkRvOfAct { get; set; }
}
