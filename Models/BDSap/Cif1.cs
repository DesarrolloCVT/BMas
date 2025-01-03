using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cif1
{
    public int FldAbsEnt { get; set; }

    public string Country { get; set; } = null!;

    public string TransCry { get; set; } = null!;

    public string? IsMandImp { get; set; }

    public string? IsMandExp { get; set; }

    public string? IsReqAllIm { get; set; }

    public string? IsReqAllEx { get; set; }
}
