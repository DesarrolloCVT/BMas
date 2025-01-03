using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cudc
{
    public int CodeId { get; set; }

    public string? NameId { get; set; }

    public int? FormId { get; set; }

    public short? UserSign { get; set; }
}
