using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ufd1
{
    public string TableId { get; set; } = null!;

    public short FieldId { get; set; }

    public short IndexId { get; set; }

    public string? FldValue { get; set; }

    public string? Descr { get; set; }

    public DateTime? FldDate { get; set; }
}
