using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osuc
{
    public short StpCode { get; set; }

    public string? StpDes { get; set; }

    public string? Action { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }
}
