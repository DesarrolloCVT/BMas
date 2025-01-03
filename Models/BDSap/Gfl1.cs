using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gfl1
{
    public string FormId { get; set; } = null!;

    public string GridId { get; set; } = null!;

    public short UserCode { get; set; }

    public int FilterId { get; set; }

    public short GridColumn { get; set; }

    public short? FilterRule { get; set; }

    public string? Value { get; set; }

    public string? ValueTo { get; set; }
}
