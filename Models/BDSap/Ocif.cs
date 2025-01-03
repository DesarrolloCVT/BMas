using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocif
{
    public int AbsEntry { get; set; }

    public string? Istable { get; set; }

    public string? Isfield { get; set; }

    public string? FieldDesc { get; set; }

    public string? FlLocation { get; set; }

    public string? FldSource { get; set; }
}
