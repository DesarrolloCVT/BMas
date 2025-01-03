using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otp
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }
}
