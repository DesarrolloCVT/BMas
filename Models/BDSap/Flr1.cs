using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flr1
{
    public int AbsId { get; set; }

    public int? LineNum { get; set; }

    public string ColName { get; set; } = null!;

    public string? CompValue { get; set; }

    public string? CompOper { get; set; }
}
