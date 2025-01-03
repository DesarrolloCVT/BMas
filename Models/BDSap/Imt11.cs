using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Imt11
{
    public short TemplateId { get; set; }

    public short AccountId { get; set; }

    public string? Sign { get; set; }

    public short PoStId { get; set; }
}
