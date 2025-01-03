using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPalletTransferidosDesdeMerma
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public decimal? CantidadPallets { get; set; }
}
