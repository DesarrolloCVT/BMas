using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orpt
{
    public string? Dscrptn { get; set; }

    public string RspType { get; set; } = null!;

    public string? IsActived { get; set; }
}
