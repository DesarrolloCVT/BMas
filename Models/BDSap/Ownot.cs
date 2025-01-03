using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ownot
{
    public string Guid { get; set; } = null!;

    public int? UserId { get; set; }

    public DateTime? Date { get; set; }

    public string? Read { get; set; }

    public string? Dismissed { get; set; }

    public int? NotiType { get; set; }
}
