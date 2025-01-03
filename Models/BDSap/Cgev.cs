using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cgev
{
    public int EventId { get; set; }

    public DateTime? EventDate { get; set; }

    public int? EventTime { get; set; }

    public string? UserCode { get; set; }

    public string? SourceIp { get; set; }

    public string? EventType { get; set; }

    public string? EventDetls { get; set; }
}
