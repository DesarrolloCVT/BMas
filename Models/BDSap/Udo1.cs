using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udo1
{
    public string Code { get; set; } = null!;

    public int SonNum { get; set; }

    public string? TableName { get; set; }

    public string? LogName { get; set; }

    public string? SonName { get; set; }
}
