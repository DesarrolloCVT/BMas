using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odll
{
    public int DllEntry { get; set; }

    public string DllName { get; set; } = null!;

    public string? DllDesp { get; set; }
}
