using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vtr2
{
    public int AbsEntry { get; set; }

    public string ObjectCode { get; set; } = null!;

    public int? FromDocNo { get; set; }

    public int? ToDocNo { get; set; }

    public string? Selected { get; set; }
}
