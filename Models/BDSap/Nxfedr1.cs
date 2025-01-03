using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nxfedr1
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UTpoDocRef { get; set; }

    public string? UFolioRef { get; set; }

    public DateTime? UFchRef { get; set; }

    public string? URazonRef { get; set; }
}
