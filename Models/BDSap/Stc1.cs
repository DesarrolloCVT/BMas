using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Stc1
{
    public string Stccode { get; set; } = null!;

    public int LineId { get; set; }

    public string? Stacode { get; set; }

    public int? Statype { get; set; }

    public string? TaxOnTcode { get; set; }

    public int? TaxOnTtype { get; set; }

    public decimal? EfctivRate { get; set; }

    public int? FmlId { get; set; }

    public string? CstCodeIn { get; set; }

    public string? CstSuffix { get; set; }

    public int? LogInstanc { get; set; }
}
