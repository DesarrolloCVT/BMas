using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtm2
{
    public int WtmCode { get; set; }

    public int WstCode { get; set; }

    public short? SortId { get; set; }

    public string? Remarks { get; set; }
}
