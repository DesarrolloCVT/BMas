using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cul1
{
    public int ParrentDoc { get; set; }

    public int LineNum { get; set; }

    public string? Param { get; set; }
}
