using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owfst
{
    public string Guid { get; set; } = null!;

    public string? FormId { get; set; }

    public int? UserId { get; set; }

    public string? ObjType { get; set; }
}
