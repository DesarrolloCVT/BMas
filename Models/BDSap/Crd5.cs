using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Crd5
{
    public string CardCode { get; set; } = null!;

    public string PmntDate { get; set; } = null!;

    public int? LogInstanc { get; set; }
}
