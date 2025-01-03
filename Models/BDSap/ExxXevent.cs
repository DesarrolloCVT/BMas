using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ExxXevent
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? UObjType { get; set; }

    public string? UTrxType { get; set; }

    public int? UNCols { get; set; }

    public string? ULKeys { get; set; }

    public string? ULValues { get; set; }
}
