using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oejb
{
    public int WizardId { get; set; }

    public string? WizardName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? PfromDate { get; set; }

    public DateTime? PtoDate { get; set; }

    public DateTime? DateOfRun { get; set; }

    public string? Status { get; set; }

    public string? ActYearCl { get; set; }

    public int? FormFinSt { get; set; }

    public int? Ebstmpl { get; set; }

    public int? EpaLtmpl { get; set; }

    public string? OverwrFinS { get; set; }

    public string? Reference { get; set; }

    public int? Hbcode { get; set; }

    public string? PayRef { get; set; }

    public int? SndrRole { get; set; }

    public string? CregNumber { get; set; }

    public string? LfbsheetD { get; set; }

    public string? LfbsheetPr { get; set; }

    public string? RegNum { get; set; }

    public string? CmpanyName { get; set; }

    public byte[]? Xmlfile { get; set; }

    public short? TimeOfRun { get; set; }
}
