using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rld1
{
    public int AbsEntry { get; set; }

    public string TargetType { get; set; } = null!;

    public string TargetFld { get; set; } = null!;

    public string? SourceFld { get; set; }

    public int? OrderNum { get; set; }

    public string? SourceType { get; set; }
}
