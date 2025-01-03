using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cprf
{
    public string FormId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ColId { get; set; } = null!;

    public int? Width { get; set; }

    public string? VisInForm { get; set; }

    public int? VisualIndx { get; set; }

    public string? EditInForm { get; set; }

    public string? VisInExpnd { get; set; }

    public int? ExpandIndx { get; set; }

    public string? EditInExp { get; set; }

    public string? Folded { get; set; }

    public short UserSign { get; set; }

    public string? ExtDisable { get; set; }

    public string? ExtInvsbl { get; set; }

    public short Tplid { get; set; }

    public string? TableName { get; set; }

    public string? ItemUid { get; set; }
}
