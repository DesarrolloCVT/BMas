using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Soi4
{
    public int WizardId { get; set; }

    public int Soinum { get; set; }

    public int DocType { get; set; }

    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? NumAtCard { get; set; }

    public int? InvEntry { get; set; }
}
