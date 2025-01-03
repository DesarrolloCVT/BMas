using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acr11
{
    public string CardCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int TributId { get; set; }

    public int? TributType { get; set; }

    public DateTime? TtstartDat { get; set; }

    public DateTime? TtendDate { get; set; }

    public int? TribRegCod { get; set; }

    public DateTime? TrcstartD { get; set; }

    public DateTime? TrcendDate { get; set; }

    public int LogInstanc { get; set; }
}
