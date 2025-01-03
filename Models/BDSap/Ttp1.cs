using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ttp1
{
    public short UserSign { get; set; }

    public int ObjectId { get; set; }

    public string DataKey { get; set; } = null!;

    public int? VisOrder { get; set; }

    public string? IsVisible { get; set; }
}
