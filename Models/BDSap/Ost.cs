using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ost
{
    public int Code { get; set; }

    public int? Technician { get; set; }

    public string? Choice { get; set; }

    public int? GroupCode { get; set; }
}
