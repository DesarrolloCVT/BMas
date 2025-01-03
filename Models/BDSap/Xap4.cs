using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xap4
{
    public int AbsEntry { get; set; }

    public int? FilEntry { get; set; }

    public int? TarEntry { get; set; }

    public string? TarType { get; set; }

    public string? TarField { get; set; }

    public string? IsBase { get; set; }
}
