using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sta1
{
    public string StaCode { get; set; } = null!;

    public int SttType { get; set; }

    public DateTime EfctDate { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? TaaSupdate { get; set; }
}
