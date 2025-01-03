using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vtr3
{
    public int AbsEntry { get; set; }

    public string ObjectCode { get; set; } = null!;

    public int SeriesCode { get; set; }
}
