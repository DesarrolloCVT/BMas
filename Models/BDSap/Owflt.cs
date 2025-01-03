using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owflt
{
    public string Guid { get; set; } = null!;

    public int? UserId { get; set; }

    public string? TableName { get; set; }

    public string? FilterName { get; set; }
}
