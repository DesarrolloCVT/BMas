using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpi2
{
    public int BaseEntry { get; set; }

    public int LineNum { get; set; }

    public int OpCode { get; set; }

    public int? ObjType { get; set; }

    public int? LogInstanc { get; set; }
}
