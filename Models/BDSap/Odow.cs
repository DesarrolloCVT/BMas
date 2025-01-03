using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odow
{
    public string Object { get; set; } = null!;

    public short SubObject { get; set; }

    public short? OwnerField { get; set; }

    public string? Active { get; set; }

    public short? UserSign { get; set; }

    public short? UpdateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DataSource { get; set; }

    public int? Ac { get; set; }

    public short? OwnerCtrl { get; set; }
}
