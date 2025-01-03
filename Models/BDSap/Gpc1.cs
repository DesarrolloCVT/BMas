using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpc1
{
    public int AbsId { get; set; }

    public int Bplid { get; set; }

    public string State { get; set; } = null!;

    public string CardCode { get; set; } = null!;
}
