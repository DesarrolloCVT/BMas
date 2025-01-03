using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ompf
{
    public int MessageUid { get; set; }

    public int FormUid { get; set; }

    public short UserSign { get; set; }

    public int? SelctedBtn { get; set; }
}
