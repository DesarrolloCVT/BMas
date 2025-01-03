using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Fam1
{
    public int WizardId { get; set; }

    public int LineNum { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }
}
