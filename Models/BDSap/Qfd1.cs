using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Qfd1
{
    public int IntrnalKey { get; set; }

    public int LineNum { get; set; }

    public string? FieldName { get; set; }

    public string? FieldDesc { get; set; }

    public string? OrigTable { get; set; }

    public string? OrigField { get; set; }

    public string? EditType { get; set; }

    public string? StatType { get; set; }

    public string? AggrType { get; set; }

    public string? LinkTable { get; set; }

    public short? DeciPlace { get; set; }

    public string? DbType { get; set; }
}
