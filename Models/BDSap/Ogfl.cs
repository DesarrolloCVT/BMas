using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogfl
{
    public string FormId { get; set; } = null!;

    public string GridId { get; set; } = null!;

    public short UserCode { get; set; }

    public int? DefFilter { get; set; }

    public int? NextFltId { get; set; }
}
