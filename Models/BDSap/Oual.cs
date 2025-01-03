using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oual
{
    public int Id { get; set; }

    public short? UserId { get; set; }

    public DateTime? ActionDate { get; set; }

    public int? ActionTime { get; set; }

    public string? ActionType { get; set; }

    public int? ObjectId { get; set; }

    public string? ObjectKey { get; set; }
}
