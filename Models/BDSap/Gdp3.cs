using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gdp3
{
    public int AbsEntry { get; set; }

    public short LineNum { get; set; }

    public string RefObjType { get; set; } = null!;

    public string RefObjKey1 { get; set; } = null!;

    public string RefObjKey2 { get; set; } = null!;
}
