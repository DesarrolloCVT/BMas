using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zcon1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UClave { get; set; }

    public string? UWhtype { get; set; }

    public int? USigCert { get; set; }

    public string? UIndNulo { get; set; }

    public string? UIndNdeb { get; set; }

    public string? UShowDec { get; set; }

    public string? UShowInd { get; set; }

    public string? UIndNde { get; set; }

    public string? UIndNce { get; set; }

    public string? UIndBrv { get; set; }

    public string? UUbcBol { get; set; }

    public string? UIndFcom { get; set; }

    public string? UIvaexe { get; set; }

    public string? UIva { get; set; }

    public string? UKardex { get; set; }

    public string? UIndicDi { get; set; }

    public string? ULibExx { get; set; }
}
