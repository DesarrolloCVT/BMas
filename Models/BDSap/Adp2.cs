using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adp2
{
    public string PrintId { get; set; } = null!;

    public string RptType { get; set; } = null!;

    public string? EmailSbj { get; set; }

    public string? EmailBody { get; set; }
}
