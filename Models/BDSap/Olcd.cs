using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Olcd
{
    public int AbsEntry { get; set; }

    public DateTime? DateUntil { get; set; }

    public short? UserSign { get; set; }
}
