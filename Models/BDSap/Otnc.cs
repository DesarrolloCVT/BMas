using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otnc
{
    public int AbsId { get; set; }

    public string TransCat { get; set; } = null!;

    public string? Locked { get; set; }
}
