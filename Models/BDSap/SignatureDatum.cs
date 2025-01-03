using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SignatureDatum
{
    public string DocEntry { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public string? Guias { get; set; }
}
