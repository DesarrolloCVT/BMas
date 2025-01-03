using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oque
{
    public string QueueId { get; set; } = null!;

    public string? Descript { get; set; }

    public int? Manager { get; set; }

    public string? Email { get; set; }

    public string? Inactive { get; set; }
}
