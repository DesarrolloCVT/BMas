using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rPromocion1
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UX4rDia { get; set; }

    public string UX4rActivo { get; set; } = null!;

    public short? UX4rDesdehora { get; set; }

    public short? UX4rHastahora { get; set; }

    public string? UX4rNomdia { get; set; }
}
