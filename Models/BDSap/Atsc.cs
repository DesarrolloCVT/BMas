using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atsc
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Situation { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short Category { get; set; }

    public string? CodeOut { get; set; }

    public string? OutDesc { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
