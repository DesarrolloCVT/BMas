using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cpt1
{
    public int AbsEntry { get; set; }

    public int SubEntry { get; set; }

    public string? Title { get; set; }

    public int? WdtEntry { get; set; }

    public short? Left { get; set; }

    public short? Right { get; set; }

    public short? Top { get; set; }

    public short? Bottom { get; set; }
}
