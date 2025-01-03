using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orfl
{
    public int ReportType { get; set; }

    public string DocType { get; set; } = null!;

    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string TaxCode { get; set; } = null!;

    public int OrdinalNum { get; set; }
}
