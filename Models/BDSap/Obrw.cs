using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obrw
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public short? Type { get; set; }

    public string? Url { get; set; }

    public string? App { get; set; }

    public string? Title { get; set; }

    public string? ShowWebTil { get; set; }

    public string? Size { get; set; }
}
