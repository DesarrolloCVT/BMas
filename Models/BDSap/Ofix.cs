using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofix
{
    public int AbsEntry { get; set; }

    public string? SrcObjType { get; set; }

    public int? SrcObjAbs { get; set; }

    public string? Canceled { get; set; }

    public DateTime? CancelDate { get; set; }
}
