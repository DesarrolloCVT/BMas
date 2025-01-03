using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Clc1
{
    public int AbsEntry { get; set; }

    public string ModObjKey { get; set; } = null!;

    public decimal? CurSize { get; set; }

    public int? Status { get; set; }
}
