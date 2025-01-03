using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aboc
{
    public int AbsEntry { get; set; }

    public string? OpCodeCat { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }
}
