using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owsv
{
    public string Guid { get; set; } = null!;

    public string? Name { get; set; }

    public string? TgtObject { get; set; }

    public string? VariantId { get; set; }

    public string? ApplyToDoc { get; set; }
}
