using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cfu
{
    public string FuncName { get; set; } = null!;

    public string UserCode { get; set; } = null!;

    public int? Count { get; set; }

    public DateTime? Since { get; set; }

    public DateTime? LastUse { get; set; }
}
