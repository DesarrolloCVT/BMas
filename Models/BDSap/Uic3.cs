using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uic3
{
    public short Tplid { get; set; }

    public short UserId { get; set; }

    public string? IsTemplate { get; set; }
}
