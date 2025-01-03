using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tps1
{
    public int TpsId { get; set; }

    public int DispOrder { get; set; }

    public int TpaId { get; set; }

    public string? Mandatory { get; set; }
}
