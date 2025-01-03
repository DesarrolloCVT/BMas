using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Putr
{
    public int SerialNum { get; set; }

    public string? CompanyVer { get; set; }

    public string? TargetVer { get; set; }

    public string? BeginTime { get; set; }

    public string? EndTime { get; set; }
}
