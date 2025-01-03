using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa9
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? DocAbs { get; set; }

    public string? DocType { get; set; }

    public int? DocLineNum { get; set; }

    public int? SnBabs { get; set; }

    public int? ManagedBy { get; set; }

    public decimal? Applied { get; set; }
}
