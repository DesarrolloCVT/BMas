using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ltf1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? LineCode { get; set; }
}
