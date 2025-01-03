using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ukd1
{
    public string TableName { get; set; } = null!;

    public short KeyId { get; set; }

    public short SubKeyId { get; set; }

    public string? ColAlias { get; set; }
}
