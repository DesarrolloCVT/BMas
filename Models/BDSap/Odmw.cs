using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odmw
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public int? CategoryId { get; set; }

    public string? DestPath { get; set; }

    public string? Extantion { get; set; }

    public short? UserSign { get; set; }

    public string? Delim { get; set; }

    public string? InclTitle { get; set; }

    public string? SetExp { get; set; }

    public string? NewRecs { get; set; }

    public string? Summary { get; set; }
}
