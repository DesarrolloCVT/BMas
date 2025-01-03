using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oird
{
    public string ReportId { get; set; } = null!;

    public int? Type { get; set; }

    public int? CategoryId { get; set; }

    public string? Revision { get; set; }

    public string? Title { get; set; }

    public byte[]? Definition { get; set; }

    public string? System { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
