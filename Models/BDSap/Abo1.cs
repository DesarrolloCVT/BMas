using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Abo1
{
    public int AbsEntry { get; set; }

    public string? ExOpCode { get; set; }

    public string? Opdscrpt { get; set; }

    public int? InOpCode { get; set; }

    public int LogInstanc { get; set; }

    public short LineId { get; set; }
}
