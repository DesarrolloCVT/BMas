using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocumentDataView
{
    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public string DocArray { get; set; } = null!;

    public int LineNum { get; set; }

    public string? VatGroup { get; set; }

    public string? TaxCode { get; set; }

    public int SubKey { get; set; }
}
