using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oqcn
{
    public int CategoryId { get; set; }

    public string? CatName { get; set; }

    public string? PermMask { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
