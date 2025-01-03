using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPalletProducidosEnvasado
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Palletizado { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public string? CtaCostoVenta { get; set; }

    public int? CantidadProducida { get; set; }

    public int? CantPallets { get; set; }
}
