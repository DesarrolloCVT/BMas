using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otw
{
    public short AbsEntry { get; set; }

    public string? TwsName { get; set; }

    public string? TwsUrl { get; set; }

    public string? TwsDescrip { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }
}
