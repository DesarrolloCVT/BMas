using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zfol1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UTipo { get; set; }

    public string? USerName { get; set; }

    public string? UFolPref { get; set; }

    public string? UDescrip { get; set; }

    public string? UWhsCode { get; set; }

    public short? USeries { get; set; }

    public string? UObjCode { get; set; }

    public string? UStatus { get; set; }
}
