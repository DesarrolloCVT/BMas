using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zfac1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short? UAno { get; set; }

    public string? UMoneda { get; set; }

    public short? USituac { get; set; }

    public decimal? UFactor { get; set; }
}
