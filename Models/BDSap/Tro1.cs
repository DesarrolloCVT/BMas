using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tro1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public int DocObjType { get; set; }

    public int DocEntry { get; set; }

    public int DocLineNum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? TranspQty { get; set; }

    public int? LogInstanc { get; set; }

    public int? DocOrdNum { get; set; }
}
