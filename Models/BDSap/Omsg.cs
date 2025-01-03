using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omsg
{
    public short Userid { get; set; }

    public string? Signature { get; set; }

    public string? UseCompSig { get; set; }

    public string? DummySig { get; set; }
}
