using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ddt1
{
    public int DdtKey { get; set; }

    public int LineNum { get; set; }

    public decimal? DdctPrcnt { get; set; }

    public decimal? MaxSum { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
