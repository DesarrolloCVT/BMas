using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ougp
{
    public int UgpEntry { get; set; }

    public string UgpCode { get; set; } = null!;

    public string? UgpName { get; set; }

    public int? BaseUom { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Locked { get; set; }
}
