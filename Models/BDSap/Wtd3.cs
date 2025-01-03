using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtd3
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string Wtcode { get; set; } = null!;

    public string KeyPart1 { get; set; } = null!;

    public string KeyPart2 { get; set; } = null!;

    public DateTime DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public decimal? Rate { get; set; }

    public string DetailType { get; set; } = null!;

    public string? DataSource { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? LogInstanc { get; set; }
}
