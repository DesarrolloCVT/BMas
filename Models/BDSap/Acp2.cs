using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acp2
{
    public int CpnNo { get; set; }

    public int CpnLineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemType { get; set; }

    public string? ItemGrp { get; set; }

    public int LogIns { get; set; }

    public int? VisOrder { get; set; }
}
