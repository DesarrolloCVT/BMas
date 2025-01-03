using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sprg
{
    public int LineNum { get; set; }

    public string UserCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? FileName { get; set; }

    public string? Path { get; set; }

    public string? Params { get; set; }

    public string? Oprtion { get; set; }

    public string? WinStyle { get; set; }
}
