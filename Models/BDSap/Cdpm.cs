using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cdpm
{
    public int PermId { get; set; }

    public string? Name { get; set; }

    public int? ObjectType { get; set; }

    public string? ObjectKey { get; set; }

    public int? Father { get; set; }

    public short? PermOption { get; set; }

    public string? System { get; set; }

    public string? Hidden { get; set; }

    public int? SortOrder { get; set; }
}
