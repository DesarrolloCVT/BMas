using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwDatoBuscaprodPreventaEerr
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? BcdCode { get; set; }

    public string? UomCode { get; set; }

    public int? UomEntry { get; set; }

    public int? Price { get; set; }
}
