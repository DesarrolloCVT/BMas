using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Req2
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string ArgName { get; set; } = null!;

    public string? ArgValue { get; set; }
}
