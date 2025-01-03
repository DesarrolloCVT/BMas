using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wsv1
{
    public string Guid { get; set; } = null!;

    public string ParentId { get; set; } = null!;

    public string? FlterFld { get; set; }

    public string? BindField { get; set; }

    public string? CardId { get; set; }
}
