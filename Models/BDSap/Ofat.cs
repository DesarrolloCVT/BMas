using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofat
{
    public string Id { get; set; } = null!;

    public string? UserId { get; set; }

    public string? Ofusername { get; set; }

    public string? AuthToken { get; set; }

    public string? IdToken { get; set; }
}
