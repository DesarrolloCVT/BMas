using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Map2
{
    public int MapId { get; set; }

    public int CodeIn { get; set; }

    public int CodeOut { get; set; }

    public int? Sequence { get; set; }

    public string? Name { get; set; }
}
