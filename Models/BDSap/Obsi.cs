using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obsi
{
    public int IndexType { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public short? UserSign { get; set; }

    public int Id { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }
}
