using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oaib
{
    public int AlertCode { get; set; }

    public short UserSign { get; set; }

    public string? Opened { get; set; }

    public DateTime? RecDate { get; set; }

    public short? RecTime { get; set; }

    public string? WasRead { get; set; }

    public string? Deleted { get; set; }

    public string? Failed { get; set; }
}
