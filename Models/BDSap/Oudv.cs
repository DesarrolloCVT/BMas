using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oudv
{
    public string Name { get; set; } = null!;

    public string? Dbtype { get; set; }

    public string? SchemaName { get; set; }

    public DateTime? CreateDate { get; set; }
}
