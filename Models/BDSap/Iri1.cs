using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Iri1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? StaType { get; set; }

    public string? TaxAcct { get; set; }

    public decimal? RecAmnt { get; set; }

    public decimal? ElgAmnt { get; set; }
}
