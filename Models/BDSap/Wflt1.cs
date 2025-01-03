using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wflt1
{
    public string ParentId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public int? Order { get; set; }

    public string? ColName { get; set; }

    public string? CompExpr { get; set; }

    public string? Value { get; set; }
}
