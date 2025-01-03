using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class PosAsignarolesdet
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UCodFuncion { get; set; }
}
