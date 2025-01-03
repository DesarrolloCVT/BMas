using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orci
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? Active { get; set; }

    public string? IsMultiple { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? UserSign2 { get; set; }
}
