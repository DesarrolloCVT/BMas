using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rin23
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? AssetCode { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountSc { get; set; }

    public string? SerialNo { get; set; }

    public int VisOrder { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjectType { get; set; }
}
