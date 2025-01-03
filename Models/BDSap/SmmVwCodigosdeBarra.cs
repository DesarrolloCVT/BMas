using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwCodigosdeBarra
{
    public string BcdCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }
}
