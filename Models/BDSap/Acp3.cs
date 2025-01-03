using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acp3
{
    public int CpnNo { get; set; }

    public int CpnLineNum { get; set; }

    public int? ParterId { get; set; }

    public int? OrlCode { get; set; }

    public string? RelatCard { get; set; }

    public string? Memo { get; set; }

    public int LogIns { get; set; }

    public int? VisOrder { get; set; }
}
