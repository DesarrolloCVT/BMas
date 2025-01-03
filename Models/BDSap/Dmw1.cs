using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dmw1
{
    public int PacCode { get; set; }

    public int QueryCode { get; set; }

    public short? UserSign { get; set; }
}
