using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocog
{
    public short GroupCode { get; set; }

    public string GroupName { get; set; } = null!;

    public decimal? Commission { get; set; }

    public decimal? PrvComsnPr { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
