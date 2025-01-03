using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odcc
{
    public int AbsEntry { get; set; }

    public string? Enable { get; set; }

    public int? Start { get; set; }

    public string? CronString { get; set; }

    public short? UserSign { get; set; }
}
