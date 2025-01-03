using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acd2
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? DprArea { get; set; }

    public string? JrnlMemo { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int? TransNum { get; set; }

    public string? JrnlMemo1 { get; set; }

    public int? TransNum1 { get; set; }
}
