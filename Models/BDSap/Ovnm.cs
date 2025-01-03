using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovnm
{
    public int NumId { get; set; }

    public string? NumName { get; set; }

    public string? First { get; set; }

    public string? Next { get; set; }

    public string? Last { get; set; }

    public string? YrDepend { get; set; }

    public string? DefaultNum { get; set; }
}
