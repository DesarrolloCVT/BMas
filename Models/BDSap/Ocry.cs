using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocry
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? AddrFormat { get; set; }

    public short? UserSign { get; set; }

    public string? IsEc { get; set; }

    public string? ReportCode { get; set; }

    public short? TaxIdDigts { get; set; }

    public int? BnkCodDgts { get; set; }

    public int? BnkBchDgts { get; set; }

    public int? BnkActDgts { get; set; }

    public int? BnkCtKdgts { get; set; }

    public string? ValDomAcct { get; set; }

    public string? ValIban { get; set; }

    public string? IsBlackLst { get; set; }

    public string? Uiccode { get; set; }

    public string? CntCodNum { get; set; }

    public string? Siscomex { get; set; }

    public string? IsIntraS { get; set; }

    public string? Eaeu { get; set; }

    public string? Iso2code { get; set; }

    public string? Iso3code { get; set; }

    public string? Isonumeric { get; set; }
}
