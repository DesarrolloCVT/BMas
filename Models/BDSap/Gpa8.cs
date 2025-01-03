using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa8
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? ProdCode { get; set; }

    public string? ProdDescr { get; set; }

    public string? DistNumber { get; set; }

    public int? SnBabs { get; set; }

    public int? ManagedBy { get; set; }

    public string? IncrAcct { get; set; }

    public string? DecrAcct { get; set; }

    public decimal? DebCredAmt { get; set; }
}
