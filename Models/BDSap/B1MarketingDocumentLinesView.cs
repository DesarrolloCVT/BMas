using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1MarketingDocumentLinesView
{
    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? LineStatus { get; set; }

    public string? AcctCode { get; set; }

    public string? Ceecflag { get; set; }

    public string? TaxRelev { get; set; }

    public string? TaxOnly { get; set; }
}
