using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aecm
{
    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public short LogInstanc { get; set; }

    public short? Uiorder { get; set; }

    public short? StrIndex { get; set; }

    public string? IsActive { get; set; }

    public string? Lhost { get; set; }

    public int? Lpid { get; set; }

    public string? Ltimeout { get; set; }

    public string? Rhost { get; set; }

    public int? Rpid { get; set; }

    public string? Rtimeout { get; set; }
}
