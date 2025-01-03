using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uic1
{
    public short Tplid { get; set; }

    public string FormId { get; set; } = null!;

    public short? Width { get; set; }

    public short? Height { get; set; }

    public string? MenuId { get; set; }
}
