using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtc1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? WtAbsEntry { get; set; }

    public decimal? Wtpercent { get; set; }

    public decimal? SumVatAmnt { get; set; }

    public decimal? SumDocTot { get; set; }

    public decimal? SumBaseAmn { get; set; }

    public decimal? SumAccumAm { get; set; }

    public decimal? SumPercpAm { get; set; }
}
