using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sive
{
    public int? TreeId { get; set; }

    public int? ParentId { get; set; }

    public int AbsEntry { get; set; }

    public short? LocType { get; set; }

    public string? LocCode { get; set; }

    public int? TransSeq { get; set; }

    public int? LayerId { get; set; }

    public decimal? LayerInQty { get; set; }

    public decimal? LayerOutQ { get; set; }

    public decimal? LayerVal { get; set; }

    public string? ItemCode { get; set; }

    public int? EntryTreeI { get; set; }

    public decimal? LayerCogs { get; set; }
}
