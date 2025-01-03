using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class OrdProdxbodega
{
    public short? UYear { get; set; }

    public short? UMonth { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitCost { get; set; }

    public int? NroRcpNo { get; set; }

    public string? Origin { get; set; }

    public decimal? CUntCst { get; set; }
}
