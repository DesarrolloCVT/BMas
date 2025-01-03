using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oack
{
    public int AbsId { get; set; }

    public int FinYear { get; set; }

    public string Quarter { get; set; } = null!;

    public string? AckNum { get; set; }

    public int Location { get; set; }
}
