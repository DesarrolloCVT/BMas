using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ejb2
{
    public int WizardId { get; set; }

    public int DocId { get; set; }

    public string? Selected { get; set; }

    public string? Mandatory { get; set; }

    public string? Type { get; set; }

    public int? RptSec { get; set; }

    public string? FilePath { get; set; }

    public byte[]? FileStorag { get; set; }

    public int? VisOrder { get; set; }
}
