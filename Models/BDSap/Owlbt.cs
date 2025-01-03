using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owlbt
{
    public string Guid { get; set; } = null!;

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Info { get; set; }

    public string? Bind { get; set; }

    public string? Target { get; set; }
}
