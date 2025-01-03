using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hem5
{
    public int EmpId { get; set; }

    public string Object { get; set; } = null!;

    public string? Peer { get; set; }

    public string? Manager { get; set; }

    public string? Subord { get; set; }

    public string? Dept { get; set; }

    public string? Branch { get; set; }

    public string? Team { get; set; }

    public int? Ac { get; set; }

    public string? Cmpny { get; set; }

    public string? EncryptIv { get; set; }
}
