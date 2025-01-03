using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oert
{
    public int NumTypeId { get; set; }

    public string NumTypeNam { get; set; } = null!;

    public int? FirstNum { get; set; }

    public int? NextNum { get; set; }

    public int? LastNum { get; set; }
}
