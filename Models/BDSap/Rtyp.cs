using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtyp
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? DefltRep { get; set; }

    public string? AddName { get; set; }

    public string? FrmType { get; set; }

    public string? MnuId { get; set; }

    public string? IsSys { get; set; }

    public int? DefltSeq { get; set; }

    public string? Type { get; set; }
}
