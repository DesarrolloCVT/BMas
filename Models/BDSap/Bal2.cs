using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bal2
{
    public int PeriodId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public int? FiscalYear { get; set; }

    public DateTime? CreateDate { get; set; }
}
