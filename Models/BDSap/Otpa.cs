using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otpa
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? DataType { get; set; }

    public int? FieldId { get; set; }

    public string? Locked { get; set; }
}
