using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osrl
{
    public string ItemCode { get; set; } = null!;

    public string SerialNum { get; set; } = null!;

    public string? CardCode { get; set; }

    public int? DocNum { get; set; }

    public short? UserSign { get; set; }
}
