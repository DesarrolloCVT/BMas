using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ird1
{
    public string ReportId { get; set; } = null!;

    public int Type { get; set; }

    public byte[]? Template { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
