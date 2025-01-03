using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uic5
{
    public short Tplid { get; set; }

    public string FormId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public short? Left { get; set; }

    public short? Right { get; set; }

    public short? Top { get; set; }

    public short? Bottom { get; set; }

    public short? CurPan { get; set; }

    public string? Caption { get; set; }

    public string? GroupItem { get; set; }
}
