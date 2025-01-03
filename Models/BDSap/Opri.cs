using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opri
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public short? UserId { get; set; }

    public string? Desc { get; set; }

    public string? Server { get; set; }

    public string? Selected { get; set; }

    public string? Dprinter { get; set; }
}
