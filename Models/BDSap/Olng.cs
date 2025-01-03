using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Olng
{
    public int Code { get; set; }

    public string ShortName { get; set; } = null!;

    public string? Name { get; set; }

    public int? SysLang { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
