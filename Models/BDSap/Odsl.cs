using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odsl
{
    public int AbsEntry { get; set; }

    public string ObjType { get; set; } = null!;

    public int DocEntry { get; set; }

    public int DocLineNum { get; set; }

    public int SchdLine { get; set; }

    public string? ItemCode { get; set; }

    public string? WhsCode { get; set; }

    public DateTime? CfmDate { get; set; }

    public decimal? CfmQty { get; set; }

    public string? FixedCfm { get; set; }

    public decimal? ReqQty { get; set; }
}
