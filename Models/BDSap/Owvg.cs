using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owvg
{
    public string Guid { get; set; } = null!;

    public int UserId { get; set; }

    public string ViewType { get; set; } = null!;

    public string ViewId { get; set; } = null!;

    public string ObjName { get; set; } = null!;

    public string? DftVrnt { get; set; }
}
