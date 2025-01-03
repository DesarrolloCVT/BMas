using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omlt
{
    public int TranEntry { get; set; }

    public string TableName { get; set; } = null!;

    public string FieldAlias { get; set; } = null!;

    public string Pk { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
