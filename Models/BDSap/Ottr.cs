using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ottr
{
    public int AbsEntry { get; set; }

    public string? Descr { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
