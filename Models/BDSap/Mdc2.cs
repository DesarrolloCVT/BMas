using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mdc2
{
    public int AbsEntry { get; set; }

    public string ObjectType { get; set; } = null!;

    public string? UserAction { get; set; }

    public string? DelContent { get; set; }
}
