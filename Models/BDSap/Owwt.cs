using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owwt
{
    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public string? Layout { get; set; }

    public string? Action { get; set; }
}
