using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vtr1
{
    public int AbsEntry { get; set; }

    public string ObjectCode { get; set; } = null!;

    public string? Sum { get; set; }

    public int? DispOrder { get; set; }

    public string? ObjectType { get; set; }

    public string? Selected { get; set; }

    public string? FromObject { get; set; }

    public string? ToObject { get; set; }

    public string AdtnlKey { get; set; } = null!;

    public decimal? Amount { get; set; }
}
