using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osqr
{
    public int IntrnalKey { get; set; }

    public int? Qcategory { get; set; }

    public string Qname { get; set; } = null!;

    public string? Qstring { get; set; }

    public string? Qtype { get; set; }

    public string? ColumnSize { get; set; }

    public int? Dbtype { get; set; }
}
