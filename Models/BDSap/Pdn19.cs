using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pdn19
{
    public int DocEntry { get; set; }

    public int BinAllocSe { get; set; }

    public int? LineNum { get; set; }

    public int? SubLineNum { get; set; }

    public int? SnBtype { get; set; }

    public int? SnBmdabs { get; set; }

    public int? BinAbs { get; set; }

    public decimal? Quantity { get; set; }

    public string? ItemCode { get; set; }

    public string? WhsCode { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? AllowNeg { get; set; }

    public short? BinActTyp { get; set; }
}
