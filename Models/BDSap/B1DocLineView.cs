using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocLineView
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ObjType { get; set; }

    public int ArrayType { get; set; }

    public string? TaxOnly { get; set; }

    public string? Ceecflag { get; set; }

    public int? CiOppLineN { get; set; }

    public string? AcctCode { get; set; }

    public string? Myftype { get; set; }
}
