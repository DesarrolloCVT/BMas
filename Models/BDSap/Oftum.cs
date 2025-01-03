using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oftum
{
    public string Id { get; set; } = null!;

    public string? Botype { get; set; }

    public string? Doctype { get; set; }

    public string? Tempformat { get; set; }

    public string? UserId { get; set; }

    public DateTime? Actiontime { get; set; }

    public string? Actiontype { get; set; }
}
