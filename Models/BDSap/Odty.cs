using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odty
{
    public int AbsEntry { get; set; }

    public string DocType { get; set; } = null!;

    public string? DocDespt { get; set; }
}
