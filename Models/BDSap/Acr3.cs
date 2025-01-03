using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acr3
{
    public string CardCode { get; set; } = null!;

    public string AcctType { get; set; } = null!;

    public string? AcctCode { get; set; }

    public int LogInstane { get; set; }

    public short? ObjType { get; set; }
}
