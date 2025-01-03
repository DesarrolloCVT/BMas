using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pmc5
{
    public int ActTypeId { get; set; }

    public string? ActType { get; set; }

    public string? LaborItem { get; set; }

    public string? Chargeable { get; set; }

    public string? Absence { get; set; }

    public int? AbsenceId { get; set; }
}
