using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ivm1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? DocType { get; set; }

    public int? DocEntry { get; set; }

    public string? GtsStatus { get; set; }
}
