using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otpl
{
    public int TplNum { get; set; }

    public string? TplName { get; set; }

    public string TplType { get; set; } = null!;

    public string TplCode { get; set; } = null!;
}
