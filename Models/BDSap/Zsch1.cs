using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zsch1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UNombre { get; set; }

    public string? UOpcion { get; set; }

    public string? UTabla { get; set; }

    public string? UInSelect { get; set; }

    public string? UInWhere { get; set; }

    public string? UInOrder { get; set; }

    public string? UDescrip { get; set; }

    public string? UDevuelve { get; set; }

    public string? UObserv { get; set; }
}
