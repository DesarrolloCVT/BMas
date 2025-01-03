using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ostq
{
    public int AbsEntry { get; set; }

    public string? QueryName { get; set; }

    public string? QueryStr { get; set; }

    public string? Severity { get; set; }

    public string? QueryGroup { get; set; }
}
