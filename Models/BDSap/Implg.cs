using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Implg
{
    public int Id { get; set; }

    public string? Owner { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? Msg { get; set; }

    public DateTime? Time { get; set; }
}
