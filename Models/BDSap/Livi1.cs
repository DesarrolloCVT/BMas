using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Livi1
{
    public int LogEntry { get; set; }

    public int CalcNum { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UserToDate { get; set; }

    public DateTime? ActuToDate { get; set; }

    public int? LastMsgId { get; set; }

    public string? Result { get; set; }

    public string? ResultStr { get; set; }

    public short? UserSign { get; set; }

    public string? IgnFail { get; set; }

    public DateTime? ReorderFrm { get; set; }

    public DateTime? ReorderTo { get; set; }

    public DateTime? StopDate { get; set; }

    public short? StopTime { get; set; }
}
