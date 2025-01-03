using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oosr
{
    public int Num { get; set; }

    public string? Descript { get; set; }

    public short? SortOrder { get; set; }

    public short? UserSign { get; set; }
}
