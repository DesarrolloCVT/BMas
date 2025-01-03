using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oupt
{
    public string AbsId { get; set; } = null!;

    public string? Name { get; set; }

    public short? Options { get; set; }

    public string? FathId { get; set; }

    public short? VisOrder { get; set; }

    public short? Levels { get; set; }

    public string? IsItem { get; set; }

    public short? Action { get; set; }

    public short? UserSign { get; set; }
}
