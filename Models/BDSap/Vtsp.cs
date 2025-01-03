using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vtsp
{
    public int AbsEntry { get; set; }

    public string TransCode { get; set; } = null!;

    public string? TransName { get; set; }

    public string? TransId { get; set; }

    public int LineNum { get; set; }

    public string? TransMode { get; set; }

    public string? VehicleTyp { get; set; }

    public string? VehicleNo { get; set; }
}
