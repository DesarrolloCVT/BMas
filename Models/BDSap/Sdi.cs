using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sdi
{
    public string FormId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ColumnId { get; set; } = null!;

    public int Language { get; set; }

    public string? ItemString { get; set; }

    public string? IsBold { get; set; }

    public string? IsItalic { get; set; }

    public short? UserSign { get; set; }
}
