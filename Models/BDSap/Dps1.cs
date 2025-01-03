using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dps1
{
    public int DepositId { get; set; }

    public int CheckKey { get; set; }

    public string? DepCancel { get; set; }
}
