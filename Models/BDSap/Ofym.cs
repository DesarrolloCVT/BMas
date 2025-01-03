using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofym
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string AssessYear { get; set; } = null!;

    public string? TcsAcmBase { get; set; }
}
