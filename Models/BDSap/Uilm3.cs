﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uilm3
{
    public int MessageId { get; set; }

    public int LineId { get; set; }

    public int? Poline { get; set; }

    public int? ItemType { get; set; }

    public string ItemCode { get; set; } = null!;

    public short? LocType { get; set; }

    public string? LocCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalLc { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseType { get; set; }

    public int? BaseLine { get; set; }

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }
}