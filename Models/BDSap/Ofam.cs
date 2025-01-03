using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofam
{
    public int WizardId { get; set; }

    public string? WizardName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? AcctDtn { get; set; }

    public string? DprArea { get; set; }

    public string? DprType { get; set; }

    public string? AssetClass { get; set; }

    public string? AssetNum { get; set; }

    public string? AssetItem { get; set; }

    public string? UpdExstItm { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? FiscalYear { get; set; }
}
