using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1PaymentLinesView
{
    public string? ObjType { get; set; }

    public int DocNum { get; set; }

    public int LineId { get; set; }

    public string? InvType { get; set; }

    public int? DocEntry { get; set; }

    public string? AcctCode { get; set; }

    public int? Bplid { get; set; }
}
