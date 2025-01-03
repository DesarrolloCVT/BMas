using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scl5
{
    public int SrvcCallId { get; set; }

    public short Line { get; set; }

    public int? ClgId { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? VisOrder { get; set; }

    public string? EncryptIv { get; set; }
}
