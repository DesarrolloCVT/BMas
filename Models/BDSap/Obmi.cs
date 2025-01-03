using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obmi
{
    public int Id { get; set; }

    public int IndexType { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? RefIndCod1 { get; set; }

    public string? RefIndCod2 { get; set; }

    public string? RefIndCod3 { get; set; }

    public short? UserSign { get; set; }
}
