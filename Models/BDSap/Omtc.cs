using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omtc
{
    public int DocEntry { get; set; }

    public short MatchId { get; set; }

    public short Round { get; set; }

    public short? MtcRule { get; set; }

    public string? MtcAlias { get; set; }

    public int? Differnce { get; set; }

    public decimal? DiffAmnt { get; set; }

    public short RuleIndex { get; set; }
}
