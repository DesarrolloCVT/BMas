using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obbi
{
    public string TableCode { get; set; } = null!;

    public int BrandCode { get; set; }

    public string GroupCode { get; set; } = null!;

    public short? UserSign { get; set; }

    public int Id { get; set; }
}
