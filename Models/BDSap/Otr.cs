using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otr
{
    public int AbsEntry { get; set; }

    public string? ObjType { get; set; }

    public int? ReportType { get; set; }

    public string? PeriodType { get; set; }

    public int? PeriodNum { get; set; }

    public short? Year { get; set; }

    public short? AdjustNum { get; set; }

    public short? ApUserSign { get; set; }

    public DateTime? ApDate { get; set; }

    public short? ApTime { get; set; }

    public string? DeclType { get; set; }

    public DateTime? ScdateFrom { get; set; }

    public DateTime? ScdateTo { get; set; }

    public int? BosCode { get; set; }

    public int? BatchNum { get; set; }
}
