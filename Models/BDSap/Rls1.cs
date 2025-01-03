using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rls1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string SrcObjType { get; set; } = null!;

    public short SrcArr { get; set; }

    public string SrcFld { get; set; } = null!;
}
