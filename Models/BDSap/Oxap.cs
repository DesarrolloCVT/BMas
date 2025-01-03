using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oxap
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public string? Default { get; set; }
}
