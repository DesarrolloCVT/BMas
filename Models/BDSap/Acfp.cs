using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acfp
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Descrip { get; set; }

    public string? App { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public string? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
