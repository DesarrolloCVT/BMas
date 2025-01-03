using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Admc
{
    public short DmcId { get; set; }

    public string? DmcAlias { get; set; }

    public string? Active { get; set; }

    public short? Priority { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public short? AdvRulCol { get; set; }

    public string? IsUdf { get; set; }
}
