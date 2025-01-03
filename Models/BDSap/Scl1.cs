using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scl1
{
    public int SrvcCallId { get; set; }

    public short Line { get; set; }

    public int? SolutionId { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? VisOredr { get; set; }

    public string? EncryptIv { get; set; }
}
