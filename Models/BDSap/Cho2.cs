using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cho2
{
    public int AbsEntry { get; set; }

    public int? ChkNum { get; set; }

    public string? Status { get; set; }

    public short? PrnBy { get; set; }

    public int LineNum { get; set; }

    public int? LogInstanc { get; set; }
}
