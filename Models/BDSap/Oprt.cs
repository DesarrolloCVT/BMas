using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oprt
{
    public int PrtId { get; set; }

    public string Name { get; set; } = null!;

    public string? RelatnType { get; set; }

    public string? RelatCard { get; set; }

    public string? Memo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? DefaultOrl { get; set; }
}
