using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ax4rMediospago1
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int LogInst { get; set; }

    public string? UX4rCodtienda { get; set; }

    public string? UX4rDescripcion { get; set; }

    public string? UX4rActivo { get; set; }
}
