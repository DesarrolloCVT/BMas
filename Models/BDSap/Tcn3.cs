using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tcn3
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string WhsCode { get; set; } = null!;

    public decimal? QtyOnHand { get; set; }
}
