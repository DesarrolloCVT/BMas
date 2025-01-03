using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmLogCaja
{
    public int IdLog { get; set; }

    public int? PreventaId { get; set; }

    public DateTime? FecharError { get; set; }

    public string? Error { get; set; }

    public string? Usuario { get; set; }
}
