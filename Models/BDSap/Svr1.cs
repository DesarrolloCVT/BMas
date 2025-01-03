using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Svr1
{
    public string AcctCode { get; set; } = null!;

    public int TransId { get; set; }

    public int TransLine { get; set; }
}
