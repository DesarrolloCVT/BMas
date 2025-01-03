using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocmn
{
    public string Guid { get; set; } = null!;

    public string? Name { get; set; }

    public string? Father { get; set; }

    public string? Type { get; set; }

    public string? SubMenu { get; set; }

    public string? MenuUid { get; set; }

    public int? ObjectType { get; set; }

    public string? ObjectKey { get; set; }

    public int? PermFolder { get; set; }

    public int? SortOrder { get; set; }
}
