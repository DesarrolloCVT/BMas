using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ebl1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public int? ReportType { get; set; }

    public string? Selected { get; set; }

    public string? Mandatory { get; set; }

    public string? DocType { get; set; }

    public byte[]? DocContent { get; set; }
}
