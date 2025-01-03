using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ctbr
{
    public short UserSign { get; set; }

    public int ToolbarId { get; set; }

    public short? Docking { get; set; }

    public short? LeftId { get; set; }

    public short? TopId { get; set; }

    public short? RightId { get; set; }

    public short? BottomId { get; set; }

    public string? VisibleId { get; set; }
}
