using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ouwtx
{
    public int AbsEntry { get; set; }

    public string SrcObjType { get; set; } = null!;

    public int SrcObjAbs { get; set; }

    public string? Cancelled { get; set; }

    public string? FullCopied { get; set; }
}
