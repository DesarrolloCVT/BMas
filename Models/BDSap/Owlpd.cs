using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owlpd
{
    public string Guid { get; set; } = null!;

    public int? UserId { get; set; }

    public string? ThemeId { get; set; }

    public string? DisQikView { get; set; }

    public int? NtfShowDay { get; set; }
}
