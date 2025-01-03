using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oist
{
    public int AbsEntry { get; set; }

    public string InstrCode { get; set; } = null!;

    public string? InstrDespt { get; set; }

    public string IsCancel { get; set; } = null!;
}
