using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Afml
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public int? SttId { get; set; }

    public string? FmlLang { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string FmlType { get; set; } = null!;

    public string? IsOrigFml { get; set; }
}
