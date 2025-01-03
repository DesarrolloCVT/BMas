using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofct
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? UserSign { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? FormView { get; set; }
}
