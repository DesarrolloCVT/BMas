using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Abp2
{
    public int Bplid { get; set; }

    public int TributId { get; set; }

    public int? TributType { get; set; }

    public DateTime? TtstartDat { get; set; }

    public DateTime? TtendDate { get; set; }

    public int? TribRegCod { get; set; }

    public DateTime? TrcstartD { get; set; }

    public DateTime? TrcendDate { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
