using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ilm2
{
    public int MessageId { get; set; }

    public short AccountId { get; set; }

    public string? AcctCode { get; set; }

    public string DebitCredi { get; set; } = null!;
}
