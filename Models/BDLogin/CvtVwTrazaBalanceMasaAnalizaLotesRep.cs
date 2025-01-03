using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTrazaBalanceMasaAnalizaLotesRep
{
    public string ItemCode { get; set; } = null!;

    public string LoteConsumo { get; set; } = null!;

    public short Nivel { get; set; }

    public decimal? CantidadConsimida { get; set; }

    public string? Of { get; set; }

    public string Clave { get; set; } = null!;
}
