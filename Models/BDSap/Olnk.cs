using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Olnk
{
    public int AbsEntry { get; set; }

    public string? LnkAddr { get; set; }

    public string? Descr { get; set; }

    public string? Provider { get; set; }
}
