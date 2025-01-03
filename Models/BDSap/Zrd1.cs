using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zrd1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string Code { get; set; } = null!;

    public int? Number { get; set; }

    public decimal? TotalSum { get; set; }

    public string? Descriptn { get; set; }
}
