using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Occt
{
    public string CctCode { get; set; } = null!;

    public string? CctName { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
