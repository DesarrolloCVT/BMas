using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oasc
{
    public short SegmentId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public short? UserSign { get; set; }
}
