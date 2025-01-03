using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imt1
{
    public short TemplateId { get; set; }

    public short AccountId { get; set; }

    public string? DebitCredi { get; set; }

    public short? OrderCalc { get; set; }
}
