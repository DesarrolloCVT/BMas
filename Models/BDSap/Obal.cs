using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obal
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public string WhsCode { get; set; } = null!;

    public int PeriodId { get; set; }

    public string EvalSystem { get; set; } = null!;

    public string DtSorting { get; set; } = null!;

    public int LayerId { get; set; }

    public DateTime? CreateDate { get; set; }
}
