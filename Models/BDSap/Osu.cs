using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osu
{
    public int DocEntry { get; set; }

    public int? SessionId { get; set; }

    public int? Type { get; set; }

    public string? Id { get; set; }

    public string? Param { get; set; }

    public DateTime? TimeStamp { get; set; }
}
