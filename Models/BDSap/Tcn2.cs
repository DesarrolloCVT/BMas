using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcn2
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? CardCode { get; set; }

    public int? AgrNo { get; set; }
}
