using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Okpf
{
    public string FactorId { get; set; } = null!;

    public string? FactorName { get; set; }

    public short? CatId { get; set; }

    public int? TemplateId { get; set; }

    public string? IsSys { get; set; }
}
