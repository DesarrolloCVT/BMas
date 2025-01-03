using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofu
{
    public string Id { get; set; } = null!;

    public string? UserId { get; set; }

    public string? Foldername { get; set; }

    public string? Locale { get; set; }

    public byte[]? Profphoto { get; set; }
}
