using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oslm
{
    public int DocId { get; set; }

    public DateTime? DocDate { get; set; }

    public int? Ref1 { get; set; }

    public int? Ref2 { get; set; }

    public string? Status { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public decimal? TotDebit { get; set; }

    public decimal? TotCredit { get; set; }

    public string? RateType { get; set; }

    public string? Comment { get; set; }

    public short? UserSign { get; set; }

    public string? Canceled { get; set; }

    public DateTime? CancelDate { get; set; }

    public short? CancelUser { get; set; }
}
