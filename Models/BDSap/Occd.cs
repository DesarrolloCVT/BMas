using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Occd
{
    public string Ccdnum { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? CustBroker { get; set; }

    public string? DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public string? SupNum { get; set; }

    public DateTime? SupDate { get; set; }

    public string? CustTerm { get; set; }

    public string? PayKey { get; set; }
}
