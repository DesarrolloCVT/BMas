using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oasg
{
    public short AbsId { get; set; }

    public string? Name { get; set; }

    public short? Size { get; set; }

    public string? Type { get; set; }

    public short? UserSign { get; set; }
}
