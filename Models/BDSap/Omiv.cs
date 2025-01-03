using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omiv
{
    public int Entry { get; set; }

    public int Number { get; set; }

    public DateTime? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public string? Currency { get; set; }

    public decimal? LastBilled { get; set; }

    public decimal? Paid { get; set; }

    public decimal? CarryForw { get; set; }

    public decimal? CurAmount { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? Obpaid { get; set; }

    public int? OblstJenum { get; set; }

    public int? Predeces { get; set; }

    public int? Successor { get; set; }

    public int? Series { get; set; }

    public string? Cancelled { get; set; }

    public int? Bplid { get; set; }
}
