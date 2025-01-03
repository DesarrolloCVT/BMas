using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cigr
{
    public string? Category { get; set; }

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;
}
