using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osoi
{
    public int WizardId { get; set; }

    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public short? UserSign { get; set; }

    public int? AgrNoFrom { get; set; }

    public int? AgrNoTo { get; set; }

    public DateTime? PdateFrm { get; set; }

    public DateTime? PdateTo { get; set; }

    public int? OrigWizId { get; set; }

    public int? OrigSoinum { get; set; }

    public string? Status { get; set; }

    public string? CorrType { get; set; }
}
