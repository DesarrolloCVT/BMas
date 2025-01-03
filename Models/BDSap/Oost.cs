using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oost
{
    public int Num { get; set; }

    public string? Descript { get; set; }

    public short StepId { get; set; }

    public decimal? CloPrcnt { get; set; }

    public string? Canceled { get; set; }

    public short? UserSign { get; set; }

    public string? SalesStage { get; set; }

    public string? PurStage { get; set; }
}
