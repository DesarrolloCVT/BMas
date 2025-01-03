using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oagp
{
    public string AgentCode { get; set; } = null!;

    public string AgentName { get; set; } = null!;

    public string? Memo { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
