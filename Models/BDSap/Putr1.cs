using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Putr1
{
    public int SerialNum { get; set; }

    public int TestId { get; set; }

    public string? TestDesc { get; set; }

    public string? Result { get; set; }

    public string? BeginTime { get; set; }

    public string? EndTime { get; set; }

    public string? Sapnote { get; set; }
}
