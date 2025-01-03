using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1SnBallocateDocView
{
    public int? SnBallocateViewLogEntry { get; set; }

    public int? SnBallocateViewDocType { get; set; }

    public int? SnBallocateViewDocEntry { get; set; }

    public int? SnBallocateViewDocLine { get; set; }

    public int? SnBallocateViewMngBy { get; set; }

    public int? SnBallocateViewSnbMdAbs { get; set; }

    public string SnBallocateViewItemCode { get; set; } = null!;

    public int SnBallocateViewSnbSysNum { get; set; }

    public string? SnBallocateViewLocCode { get; set; }

    public decimal? SnBallocateViewAllocQty { get; set; }
}
