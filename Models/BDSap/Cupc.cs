using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cupc
{
    public string ObjectId { get; set; } = null!;

    public int? CntBefore { get; set; }

    public int? CntAfter { get; set; }

    public string? Reported { get; set; }
}
