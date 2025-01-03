using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpi1
{
    public int BaseEntry { get; set; }

    public int LineNum { get; set; }

    public string? Canceled { get; set; }

    public string? DocType { get; set; }

    public int? RefEntry1 { get; set; }

    public int? RefEntry2 { get; set; }

    public short? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public int? RefType { get; set; }

    public string? EncryptIv { get; set; }
}
