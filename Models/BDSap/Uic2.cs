using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uic2
{
    public short Tplid { get; set; }

    public string FormId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? Visible { get; set; }

    public string? VisibleCtl { get; set; }

    public string? Editable { get; set; }

    public string? EditbleCtl { get; set; }

    public short? Left { get; set; }

    public short? Top { get; set; }

    public short? Right { get; set; }

    public short? Bottom { get; set; }

    public short? FromPane { get; set; }

    public short? ToPane { get; set; }

    public string? Udf { get; set; }

    public string? TableName { get; set; }
}
