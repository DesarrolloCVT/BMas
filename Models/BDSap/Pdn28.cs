﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pdn28
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int ChildNum { get; set; }

    public int TrackingNt { get; set; }

    public int TrackiNtLn { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnusedQty { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public int? SubLineNum { get; set; }
}