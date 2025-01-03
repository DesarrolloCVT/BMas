using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Kpi3
{
    public int AbsEntry { get; set; }

    public int? Kpientry { get; set; }

    public string? Type { get; set; }

    public string? FldName { get; set; }

    public string? FldMethod { get; set; }

    public string? Operator { get; set; }

    public string? DbType { get; set; }

    public int? SqlType { get; set; }

    public string? FromValue { get; set; }

    public string? ToValue { get; set; }

    public string? DftValue { get; set; }

    public string? ParamType { get; set; }

    public string? UdqPh { get; set; }

    public string? UdqOp { get; set; }
}
