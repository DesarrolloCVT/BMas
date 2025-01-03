using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1JournalEntryVendorView
{
    public int TransId { get; set; }

    public string? CardCodeMin { get; set; }

    public string? CardCodeMax { get; set; }
}
