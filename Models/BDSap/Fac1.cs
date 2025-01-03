using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Fac1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? DprArea { get; set; }

    public string? TransType { get; set; }

    public string? OldDprType { get; set; }

    public string? NewDprType { get; set; }

    public int? OldUsfLife { get; set; }

    public int? NewUsfLife { get; set; }

    public DateTime? OldDprDate { get; set; }

    public DateTime? NewDprDate { get; set; }

    public decimal? OldSalVal { get; set; }

    public decimal? NewSalVal { get; set; }

    public int? OldTtlUnit { get; set; }

    public int? NewTtlUnit { get; set; }
}
