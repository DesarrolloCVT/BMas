using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ancm
{
    public int AbsEntry { get; set; }

    public string NcmCode { get; set; } = null!;

    public string? Descrip { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string GroupCode { get; set; } = null!;

    public short? Group { get; set; }
}
