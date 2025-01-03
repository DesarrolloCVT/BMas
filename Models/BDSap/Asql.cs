using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Asql
{
    public string SqlCode { get; set; } = null!;

    public string? SqlName { get; set; }

    public string? SqlText { get; set; }

    public string? ParamList { get; set; }

    public string? ParamDetai { get; set; }

    public string? InternalS { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? DataVers { get; set; }
}
