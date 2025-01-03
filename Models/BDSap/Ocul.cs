using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocul
{
    public int DocEntry { get; set; }

    public int? StartRef { get; set; }

    public int? EventType { get; set; }

    public string? DateTime { get; set; }
}
