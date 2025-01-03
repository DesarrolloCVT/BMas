using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocsn
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public int? Section { get; set; }

    public int? Location { get; set; }

    public short? DfltSeries { get; set; }
}
