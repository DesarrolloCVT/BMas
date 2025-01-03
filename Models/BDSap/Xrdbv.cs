using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xrdbv
{
    public string DbobjVer { get; set; } = null!;

    public string? DbobjVerDe { get; set; }

    public DateTime? DbobjVerUp { get; set; }

    public string? ParVer { get; set; }

    public string? ParVerDesc { get; set; }

    public DateTime? ParVerUpd { get; set; }

    public string? Partner { get; set; }

    public string? PartnerDbv { get; set; }
}
