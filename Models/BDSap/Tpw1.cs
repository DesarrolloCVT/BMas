using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpw1
{
    public int AbsEntry { get; set; }

    public DateTime? FromPeriod { get; set; }

    public DateTime? ToPeriod { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? TaxCategry { get; set; }

    public int? LocCode { get; set; }
}
