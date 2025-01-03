using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otpr
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? Display { get; set; }

    public int? FieldId { get; set; }

    public string? Locked { get; set; }

    public string? DataType { get; set; }
}
