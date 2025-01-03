using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obnh
{
    public int IdNumber { get; set; }

    public int ActKey { get; set; }

    public int Bsnum { get; set; }

    public DateTime Bsdate { get; set; }

    public string? Status { get; set; }

    public string? Imported { get; set; }

    public decimal? StrtBlncF { get; set; }

    public decimal? EndBlncF { get; set; }

    public string? Currency { get; set; }

    public decimal? StrtBlncL { get; set; }

    public decimal? EndBlncL { get; set; }

    public string? FileCrc { get; set; }

    public string? StmtGuid { get; set; }

    public string? BsfileNum { get; set; }

    public int? PeriodAbs { get; set; }

    public int? DfltBpl { get; set; }

    public DateTime? OrigBsdate { get; set; }
}
