using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrp
{
    public short CrTypeCode { get; set; }

    public string CrTypeName { get; set; } = null!;

    public short? CreditCard { get; set; }

    public string? DueTerms { get; set; }

    public decimal? MinCredit { get; set; }

    public decimal? MinToPay { get; set; }

    public decimal? MaxValid { get; set; }

    public string? InstalMent { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
