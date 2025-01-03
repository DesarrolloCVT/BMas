using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Annm
{
    public string ObjectCode { get; set; } = null!;

    public int? AutoKey { get; set; }

    public int? DfltSeries { get; set; }

    public int? UpdCounter { get; set; }

    public short? UserSign { get; set; }

    public string DocSubType { get; set; } = null!;

    public string? DocAlias { get; set; }

    public string? PeriodTyp { get; set; }

    public int LogInstanc { get; set; }
}
