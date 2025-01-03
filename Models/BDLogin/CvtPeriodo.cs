using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPeriodo
{
    public string CodPeriodo { get; set; } = null!;

    public int AnoPeriodo { get; set; }

    public string? DescPeriodo { get; set; }

    public short MesPeriodo { get; set; }
}
