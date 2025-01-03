using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwRegionesExcel
{
    public string Nregion { get; set; } = null!;

    public string? Region { get; set; }

    public string RegAbrev { get; set; } = null!;

    public string Zona { get; set; } = null!;
}
