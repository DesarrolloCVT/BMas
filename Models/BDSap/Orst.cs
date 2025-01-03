using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orst
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Desc { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? LogInstanc { get; set; }
}
