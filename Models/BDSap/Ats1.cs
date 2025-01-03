using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ats1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public int? TransMode { get; set; }

    public string? VehicleTyp { get; set; }

    public string? VehicleNo { get; set; }

    public int LogInstanc { get; set; }
}
