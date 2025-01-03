using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rdfl
{
    public string DoumntDode { get; set; } = null!;

    public int UserId { get; set; }

    public string? DfltReport { get; set; }

    public string CardCode { get; set; } = null!;

    public int? DfltSeq { get; set; }

    public string? Type { get; set; }
}
