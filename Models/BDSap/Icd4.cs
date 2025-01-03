using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Icd4
{
    public int DocEntry { get; set; }

    public int CounterNum { get; set; }

    public int CounteType { get; set; }

    public int CounterId { get; set; }

    public string? CounteName { get; set; }

    public int? LogIns { get; set; }

    public int? VisOrder { get; set; }
}
