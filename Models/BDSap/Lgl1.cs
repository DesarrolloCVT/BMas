using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Lgl1
{
    public int AbsEntry { get; set; }

    public int LineSeq { get; set; }

    public string? LineType { get; set; }

    public string? TaxCode { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? Amount { get; set; }
}
