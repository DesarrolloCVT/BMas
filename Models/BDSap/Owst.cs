using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owst
{
    public int WstCode { get; set; }

    public string Name { get; set; } = null!;

    public string? Remarks { get; set; }

    public short? MaxReqr { get; set; }

    public short? UserSign { get; set; }

    public short? MaxRejReqr { get; set; }
}
