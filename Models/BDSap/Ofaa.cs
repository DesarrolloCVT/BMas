using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofaa
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Locked { get; set; }

    public int? SnapshotId { get; set; }
}
