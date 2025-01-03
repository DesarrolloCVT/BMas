using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wht1
{
    public string Wtcode { get; set; } = null!;

    public DateTime? EffecDate { get; set; }

    public decimal? Rate { get; set; }

    public int? LogInstanc { get; set; }

    public decimal? TdsRate { get; set; }

    public decimal? SurRate { get; set; }

    public decimal? CessRate { get; set; }

    public decimal? HscRate { get; set; }

    public short? PmntTerms { get; set; }

    public int LineNum { get; set; }

    public decimal? IgstRate { get; set; }

    public decimal? CgstRate { get; set; }

    public decimal? SgstRate { get; set; }

    public decimal? UtgstRate { get; set; }

    public decimal? CsgstRate { get; set; }

    public int? UomEntry { get; set; }

    public string? UoMcode { get; set; }

    public decimal? FixedAmnt { get; set; }

    public string? Currency { get; set; }

    public decimal? ItrNcrate { get; set; }

    public decimal? PanNcrate { get; set; }
}
