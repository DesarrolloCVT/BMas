using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trn1
{
    public int TrnAbsEntr { get; set; }

    public int LineNum { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemType { get; set; } = null!;

    public string? SlimType { get; set; }

    public int? MaxLength { get; set; }

    public string? SourceText { get; set; }

    public string? Memo { get; set; }
}
