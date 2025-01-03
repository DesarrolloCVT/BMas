using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AposSeries
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int? DocEntry { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int LogInst { get; set; }

    public int? UserSign { get; set; }

    public string? Transfered { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public string? UCodTienda { get; set; }

    public int? UCodDocu { get; set; }

    public string? UNomDocu { get; set; }

    public int? USerElec { get; set; }

    public string? USerNameE { get; set; }

    public int? USerManu { get; set; }

    public string? USerNameM { get; set; }

    public string UEstado { get; set; } = null!;

    public string? UX4rIndicmanuale { get; set; }

    public string? UX4rIndicmanualm { get; set; }
}
