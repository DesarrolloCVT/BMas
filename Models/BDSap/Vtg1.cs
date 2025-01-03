using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vtg1
{
    public string Code { get; set; } = null!;

    public DateTime EffecDate { get; set; }

    public decimal? Rate { get; set; }

    public decimal? EquVatPr { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? FixedAmout { get; set; }

    public string? TaxType { get; set; }

    public int? LogInstanc { get; set; }

    public short? DatevCode { get; set; }
}
