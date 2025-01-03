using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nnm4
{
    public short Eseries { get; set; }

    public int? Series { get; set; }

    public string? SeriesName { get; set; }

    public string InitialNum { get; set; } = null!;

    public string? NextNumber { get; set; }

    public string? LastNum { get; set; }

    public string? Prefix { get; set; }

    public int? ApprovYear { get; set; }

    public int? ApprovNum { get; set; }

    public string? Remark { get; set; }
}
