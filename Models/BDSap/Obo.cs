using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obo
{
    public int AbsEntry { get; set; }

    public string? IsUsed { get; set; }

    public DateTime EffecDate { get; set; }

    public int? FileFmtCo { get; set; }

    public string? IsDeleted { get; set; }

    public string ReportType { get; set; } = null!;
}
