using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orld
{
    public int AbsEntry { get; set; }

    public string ObjectCode { get; set; } = null!;

    public string DocSubType { get; set; } = null!;

    public string? Status { get; set; }
}
