using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flt1
{
    public string FormNo { get; set; } = null!;

    public string Code { get; set; } = null!;

    public short UserSign { get; set; }

    public int? ExNumData1 { get; set; }

    public int? ExNumData2 { get; set; }

    public int? ExNumData3 { get; set; }

    public string? ExStrData1 { get; set; }

    public string? ExStrData2 { get; set; }

    public string? ExStrData3 { get; set; }

    public string FilterName { get; set; } = null!;
}
