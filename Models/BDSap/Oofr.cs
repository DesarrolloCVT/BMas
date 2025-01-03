using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oofr
{
    public int Num { get; set; }

    public string? Descript { get; set; }

    public short? SortOrder { get; set; }

    public short? UserSign { get; set; }
}
