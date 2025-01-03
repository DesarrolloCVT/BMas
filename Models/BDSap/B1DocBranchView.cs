using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1DocBranchView
{
    public string? CardCode { get; set; }

    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public int? Bplid { get; set; }
}
