using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rcon
{
    public string DocCode { get; set; } = null!;

    public int ConnId { get; set; }

    public string? OldServer { get; set; }

    public string? OldDbName { get; set; }

    public string? NewServer { get; set; }

    public string? NewDbName { get; set; }

    public string? UserCode { get; set; }

    public short? SubIndex { get; set; }

    public string? SubName { get; set; }
}
