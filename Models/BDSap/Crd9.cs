using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Crd9
{
    public string CardCode { get; set; } = null!;

    public int? IstransMod { get; set; }

    public int? Isincoterm { get; set; }

    public int? Isstate { get; set; }

    public int? IsnatTrans { get; set; }

    public int? IsstatProc { get; set; }

    public int? IscustProc { get; set; }

    public string? Iscryorig { get; set; }

    public int? Isport { get; set; }

    public string? IsdomFrgld { get; set; }

    public string? Isrelevant { get; set; }
}
