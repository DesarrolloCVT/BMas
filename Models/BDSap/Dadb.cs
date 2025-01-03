using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dadb
{
    public int AbsEntry { get; set; }

    public string? ItemCode { get; set; }

    public int? LocCode { get; set; }

    public decimal? OpenBal { get; set; }
}
