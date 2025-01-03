using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dwz1
{
    public int WizardId { get; set; }

    public string CardCode { get; set; } = null!;

    public string? DunAddr { get; set; }

    public string? CheckedBp { get; set; }

    public string? FaxNum { get; set; }

    public string? Email { get; set; }

    public string? Dppstatus { get; set; }
}
