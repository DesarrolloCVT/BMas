using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPorcentajePalletTransferidosDesdeMerma
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public decimal? TotalPallets { get; set; }

    public decimal? Porcentaje { get; set; }

    public string? CostoVenta { get; set; }
}
