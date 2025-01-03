using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocuc
{
    public int AbsEntry { get; set; }

    public int? Type { get; set; }

    public string? Param { get; set; }

    public string? Value { get; set; }
}
