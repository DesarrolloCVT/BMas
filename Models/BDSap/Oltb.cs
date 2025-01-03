using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oltb
{
    public int AbsId { get; set; }

    public int? LocCode { get; set; }

    public int? Statype { get; set; }

    public string? Stacode { get; set; }

    public string? BalaType { get; set; }

    public decimal? Balance { get; set; }
}
