using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Taasf
{
    public int LogInstanc { get; set; }

    public int Internal { get; set; }

    public string? TaxCode { get; set; }

    public DateTime? DocDate { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public decimal? OldRate { get; set; }

    public decimal? NewRate { get; set; }

    public string? FixType { get; set; }

    public string? IsOk { get; set; }

    public string? Descr { get; set; }
}
