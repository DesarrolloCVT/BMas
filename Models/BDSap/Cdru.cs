using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cdru
{
    public int UserId { get; set; }

    public string ObjectId { get; set; } = null!;

    public string PartOf { get; set; } = null!;

    public string? Disabled { get; set; }
}
