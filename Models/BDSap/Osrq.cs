﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osrq
{
    public string ItemCode { get; set; } = null!;

    public int SysNumber { get; set; }

    public string WhsCode { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public decimal? CommitQty { get; set; }

    public decimal? CountQty { get; set; }

    public int AbsEntry { get; set; }

    public int? MdAbsEntry { get; set; }

    public int? TrackingNt { get; set; }

    public int? TrackiNtLn { get; set; }

    public decimal? Ccdquant { get; set; }
}
