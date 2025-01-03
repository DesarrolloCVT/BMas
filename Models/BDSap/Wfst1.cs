using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wfst1
{
    public string ParentId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? ItemId { get; set; }

    public int? Order { get; set; }

    public string? Visible { get; set; }

    public string? Editable { get; set; }

    public string? VisInGrid { get; set; }

    public string? EditInGrid { get; set; }
}
