using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTrazaBalanceMasaAnalizaLotesMp
{
    public string ItemCode { get; set; } = null!;

    public string LoteConsumo { get; set; } = null!;

    public decimal? CantidadConsumida { get; set; }

    public string Clave { get; set; } = null!;
}
