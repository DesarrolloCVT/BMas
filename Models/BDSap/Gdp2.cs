using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gdp2
{
    public int AbsEntry { get; set; }

    public short LineNum { get; set; }

    public string NatObjType { get; set; } = null!;

    public int NatObjArr { get; set; }

    public string NatObjKey1 { get; set; } = null!;

    public string NatObjKey2 { get; set; } = null!;

    public int? Result { get; set; }

    public string? ErrorStr { get; set; }
}
