using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcn1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCcdnum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? CntrOrigin { get; set; }

    public decimal? AccQtyAp { get; set; }

    public decimal? AccQtyAr { get; set; }

    public decimal? AccRelQty { get; set; }

    public short? CstGrpCode { get; set; }
}
