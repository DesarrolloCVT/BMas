using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oshp
{
    public short TrnspCode { get; set; }

    public string TrnspName { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? WebSite { get; set; }

    public string? Active { get; set; }
}
