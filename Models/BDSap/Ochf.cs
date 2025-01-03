using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ochf
{
    public string ObjName { get; set; } = null!;

    public short? UserSign { get; set; }

    public DateTime? UpdateDate { get; set; }
}
