using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ipd3
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int SnbIndex { get; set; }

    public string? ItemCode { get; set; }

    public string? WhsCode { get; set; }

    public int? ObjId { get; set; }

    public int? ObjAbs { get; set; }

    public int? DrfWobjAbs { get; set; }

    public decimal? Quantity { get; set; }

    public int? SubLineNum { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int? TakerType { get; set; }
}
