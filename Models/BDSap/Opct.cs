using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opct
{
    public int DocEntry { get; set; }

    public string TmplCode { get; set; } = null!;

    public string? TmplName { get; set; }

    public byte[]? Xmlfile { get; set; }
}
