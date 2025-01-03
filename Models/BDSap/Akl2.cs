using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Akl2
{
    public int AbsEntry { get; set; }

    public int PickEntry { get; set; }

    public int Pkl2LinNum { get; set; }

    public string? ItemCode { get; set; }

    public int? ManagedBy { get; set; }

    public int? SnBentry { get; set; }

    public int? BinAbs { get; set; }

    public string? AllowNeg { get; set; }

    public decimal? RelQtty { get; set; }

    public decimal? PickQtty { get; set; }

    public string? ObjType { get; set; }

    public int LogInstanc { get; set; }
}
