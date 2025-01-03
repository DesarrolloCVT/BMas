using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class IxvItlMin
{
    public int? LogEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public int SysNumber { get; set; }
}
