using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Map1
{
    public int MapId { get; set; }

    public int Code { get; set; }

    public string? Type { get; set; }

    public string? RuleType { get; set; }

    public string? RuleRef { get; set; }

    public string? RefId { get; set; }

    public string? RuleVer { get; set; }

    public string? IsFinal { get; set; }
}
