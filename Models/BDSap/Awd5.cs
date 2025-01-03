using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awd5
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string Wtcode { get; set; } = null!;

    public int ExpnsCode { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? DataSource { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int LogInstanc { get; set; }
}
