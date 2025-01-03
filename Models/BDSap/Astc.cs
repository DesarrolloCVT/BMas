using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Astc
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Rate { get; set; }

    public string? Freight { get; set; }

    public short? UserSign { get; set; }

    public string? ValidForAr { get; set; }

    public string? ValidForAp { get; set; }

    public int? TfcId { get; set; }

    public string? Lock { get; set; }

    public string? TaxIcms { get; set; }

    public string? IsItmLevel { get; set; }

    public string? CfopIn { get; set; }

    public string? CfopOut { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Fadebit { get; set; }

    public string? IsSystem { get; set; }

    public string? VatExempt { get; set; }

    public string? HashInpNm { get; set; }

    public DateTime? CheckDate { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
