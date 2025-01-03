using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec7
{
    public int AbsEntry { get; set; }

    public string? Code { get; set; }

    public int? Priority { get; set; }

    public string? Bpcode { get; set; }

    public string? Country { get; set; }

    public int? Serie { get; set; }

    public string? DocType { get; set; }

    public string? DocSubType { get; set; }

    public int? ExportFmt { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? LogInstanc { get; set; }

    public string? FileNp { get; set; }
}
