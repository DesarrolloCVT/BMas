using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aac
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? AssetType { get; set; }

    public decimal? LimitFrom { get; set; }

    public decimal? LimitTo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Bplid { get; set; }

    public int? AttrGrp { get; set; }

    public int? SnapshotId { get; set; }
}
