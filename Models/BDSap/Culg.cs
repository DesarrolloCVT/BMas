using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Culg
{
    public int LogId { get; set; }

    public int? VersFrom { get; set; }

    public int? VersTo { get; set; }

    public string? TableId { get; set; }

    public string? OnCreate { get; set; }

    public string? ErrLevel { get; set; }

    public string? InQuery { get; set; }

    public string? ErrMessage { get; set; }

    public string? UpgStart { get; set; }

    public int? UserId { get; set; }
}
