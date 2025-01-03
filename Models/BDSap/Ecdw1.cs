using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ecdw1
{
    public int AbsEntry { get; set; }

    public string DocType { get; set; } = null!;

    public int ExNumData1 { get; set; }

    public int ExNumData2 { get; set; }

    public int? ExNumData3 { get; set; }

    public string? ExStrData1 { get; set; }

    public string? ExStrData2 { get; set; }

    public string? ExStrData3 { get; set; }
}
