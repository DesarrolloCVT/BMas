using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpl1
{
    public int TplNum { get; set; }

    public int LineNum { get; set; }

    public int? FieldPos { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcObjType { get; set; }
}
