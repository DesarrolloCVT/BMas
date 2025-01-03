using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Msn1
{
    public int AbsEntry { get; set; }

    public string WhsCode { get; set; } = null!;

    public string? ReqSel { get; set; }

    public string? InvtSel { get; set; }

    public string? ExtIvntSel { get; set; }
}
