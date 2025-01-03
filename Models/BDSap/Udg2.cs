using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udg2
{
    public string Code { get; set; } = null!;

    public short CreditCard { get; set; }

    public string? AcctCode { get; set; }
}
