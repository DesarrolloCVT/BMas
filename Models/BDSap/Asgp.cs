using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Asgp
{
    public int AbsEntry { get; set; }

    public string ServiceGrp { get; set; } = null!;

    public string? Descrip { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
