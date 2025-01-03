using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rParametriza1
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UX4rDocumento { get; set; }

    public string? UX4rObjeto { get; set; }

    public string? UX4rSubtipo { get; set; }

    public string? UX4rTipoimpresion { get; set; }
}
