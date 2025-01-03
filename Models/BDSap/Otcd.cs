using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otcd
{
    public int AbsId { get; set; }

    public string TcdType { get; set; } = null!;

    public string? DftArCode { get; set; }

    public string? DftApCode { get; set; }
}
