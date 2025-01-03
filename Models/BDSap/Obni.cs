using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obni
{
    public int IndexType { get; set; }

    public int Code { get; set; }

    public string? Descr { get; set; }

    public short? UserSign { get; set; }

    public int Id { get; set; }
}
