using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DeferredDocAppliedTotalsView
{
    public string? ObjType { get; set; }

    public int? AbsEntry { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? EqSum { get; set; }

    public decimal? DeductSum { get; set; }

    public decimal? TotalSum { get; set; }
}
