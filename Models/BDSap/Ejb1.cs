using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ejb1
{
    public int WizardId { get; set; }

    public int LineNum { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? CommId { get; set; }

    public DateTime? DateOfBrth { get; set; }

    public DateTime? DateOfSign { get; set; }

    public int? AbsEntry { get; set; }

    public int? LineNumEjd { get; set; }
}
