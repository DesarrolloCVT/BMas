using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Datb
{
    public int AbsEntry { get; set; }

    public int? LocCode { get; set; }

    public int? NfTaxId { get; set; }

    public int? TaxComId { get; set; }

    public int? MatType { get; set; }

    public decimal? ArchBal { get; set; }

    public string? TaxAcct { get; set; }

    public string? IsPla { get; set; }

    public string? IsTaxCred { get; set; }
}
