using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owhl
{
    public DateTime ImportDate { get; set; }

    public int? HashCount { get; set; }

    public string? Comment { get; set; }

    public DateTime? NextDate { get; set; }
}
