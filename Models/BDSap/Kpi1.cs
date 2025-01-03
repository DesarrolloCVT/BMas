using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Kpi1
{
    public int AbsEntry { get; set; }

    public int? Kpientry { get; set; }

    public int? Type { get; set; }

    public string? FieldName { get; set; }

    public string? Method { get; set; }

    public string? DbType { get; set; }

    public string? DefValue { get; set; }
}
