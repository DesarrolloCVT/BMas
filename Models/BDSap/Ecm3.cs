using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ecm3
{
    public int AbsEntry { get; set; }

    public int LogNum { get; set; }

    public string? LogType { get; set; }

    public string? LogMessage { get; set; }

    public string? LogData { get; set; }

    public DateTime? LogOpDate { get; set; }

    public int? LogOpTs { get; set; }

    public int? ExportFmt { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public short? LogInstanc { get; set; }

    public string? ExportFile { get; set; }
}
