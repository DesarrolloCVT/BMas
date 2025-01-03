using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acrc
{
    public short CreditCard { get; set; }

    public string? CardName { get; set; }

    public string? AcctCode { get; set; }

    public string? Phone { get; set; }

    public string? CompanyId { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? IntTaxCode { get; set; }

    public short? UserSign2 { get; set; }

    public string? Country { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rIdTbk { get; set; }

    public string? UX4rInterkey { get; set; }
}
