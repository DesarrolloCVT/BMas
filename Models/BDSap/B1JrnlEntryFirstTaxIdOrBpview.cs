using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1JrnlEntryFirstTaxIdOrBpview
{
    public int TransId { get; set; }

    public int LineId { get; set; }

    public string? TaxId { get; set; }

    public string? Bpcode { get; set; }
}
