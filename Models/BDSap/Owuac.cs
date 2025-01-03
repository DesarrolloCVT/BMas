using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owuac
{
    public string Guid { get; set; } = null!;

    public string? AppId { get; set; }

    public string? AppType { get; set; }

    public int? Count { get; set; }

    public string? Timestamp { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? UsageArray { get; set; }

    public int? UserId { get; set; }

    public string? RecentDay { get; set; }
}
