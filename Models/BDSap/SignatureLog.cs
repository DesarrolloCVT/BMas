using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SignatureLog
{
    public string DocEntry { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public string? Result { get; set; }
}
