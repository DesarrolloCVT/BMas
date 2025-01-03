using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tfc1
{
    public int TfcId { get; set; }

    public int DispOrder { get; set; }

    public int? TypeId { get; set; }

    public int? FmlId { get; set; }
}
