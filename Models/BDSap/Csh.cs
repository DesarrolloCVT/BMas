using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Csh
{
    public string FormId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ColId { get; set; } = null!;

    public short? ActionT { get; set; }

    public int? QueryId { get; set; }

    public int IndexId { get; set; }

    public string? Refresh { get; set; }

    public string? FieldId { get; set; }

    public string? FrceRfrsh { get; set; }

    public string? ByField { get; set; }
}
