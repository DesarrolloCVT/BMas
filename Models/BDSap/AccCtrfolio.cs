using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AccCtrfolio
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? UPrimFolio { get; set; }

    public int? UUltFolio { get; set; }

    public int? UPromMens { get; set; }

    public DateTime? UFVenc { get; set; }
}
