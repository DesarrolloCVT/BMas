using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTrazaBalanceMasaAnalizaLotesPt
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string LoteConsumo { get; set; } = null!;

    public decimal? CantidadConsumida { get; set; }

    public string Clave { get; set; } = null!;
}
