using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1SnB1stAllocDocView
{
    public int? SnB1stAllocViewLogEntry { get; set; }

    public int? SnB1stAllocViewDocType { get; set; }

    public int? SnB1stAllocViewDocEntry { get; set; }

    public int? SnB1stAllocViewDocNum { get; set; }

    public int? SnB1stAllocViewMngBy { get; set; }

    public int? SnB1stAllocViewSnbMdAbs { get; set; }

    public string SnB1stAllocViewItemCode { get; set; } = null!;

    public int SnB1stAllocViewSnbSysNum { get; set; }

    public string? SnB1stAllocViewLocCode { get; set; }

    public decimal? SnB1stAllocViewAllocQty { get; set; }
}
