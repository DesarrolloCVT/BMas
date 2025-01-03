using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcd5
{
    public int AbsId { get; set; }

    public int? Tcd3Id { get; set; }

    public int? UsageCode { get; set; }

    public string? TaxCode { get; set; }

    public string? Type { get; set; }

    public string? ExpTaxCode { get; set; }

    public string? PurTaxCode { get; set; }
}
