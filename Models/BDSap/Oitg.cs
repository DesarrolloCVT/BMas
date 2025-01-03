using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oitg
{
    public short ItmsTypCod { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public short? UserSign { get; set; }
}
