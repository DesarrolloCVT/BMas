using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mpo1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? ThirdPid { get; set; }

    public string? ThirdPval { get; set; }
}
