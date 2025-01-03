using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tgpa
{
    public int AbsEntry { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public int? LineId { get; set; }

    public string? Selected { get; set; }

    public string? DocType { get; set; }

    public int? DocNum { get; set; }

    public int? DocAbs { get; set; }

    public int? DocLineNum { get; set; }

    public int? ManagedBy { get; set; }

    public int? SysNumber { get; set; }
}
