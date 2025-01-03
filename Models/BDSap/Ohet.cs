using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohet
{
    public int TransferId { get; set; }

    public DateTime? TransStart { get; set; }

    public DateTime? TransEnd { get; set; }

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public short? StartTime { get; set; }

    public short? EndTime { get; set; }
}
