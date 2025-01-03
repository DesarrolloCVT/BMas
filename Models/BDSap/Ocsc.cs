using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocsc
{
    public int DocEntry { get; set; }

    public string? Name { get; set; }

    public string? User { get; set; }

    public string? Password { get; set; }

    public string? Url { get; set; }

    public string? IsDefault { get; set; }

    public string? Port { get; set; }
}
