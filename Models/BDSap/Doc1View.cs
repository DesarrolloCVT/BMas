using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Doc1View
{
    public int DocEntry { get; set; }

    public int DocType { get; set; }

    public int LineNum { get; set; }

    public string? Model { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? Cfopcode { get; set; }
}
