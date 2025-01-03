using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ollr
{
    public int AbsEntry { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public int? EreportId { get; set; }

    public string? Status { get; set; }

    public string? Log { get; set; }

    public int? ReportInst { get; set; }

    public string? VersionNum { get; set; }
}
