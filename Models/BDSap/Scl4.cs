using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scl4
{
    public int SrcvCallId { get; set; }

    public short Line { get; set; }

    public string PartType { get; set; } = null!;

    public int DocAbs { get; set; }

    public string Object { get; set; } = null!;

    public DateTime? DocPstDate { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? DocNumber { get; set; }

    public string? Transfered { get; set; }

    public int? VisOrder { get; set; }

    public string? StckTrnDir { get; set; }

    public short? Instance { get; set; }
}
