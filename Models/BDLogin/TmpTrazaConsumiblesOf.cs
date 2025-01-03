using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class TmpTrazaConsumiblesOf
{
    public int AutoIncrement { get; set; }

    public string Clave { get; set; } = null!;

    public int NumOf { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal CantConsumidaTot { get; set; }

    public string LoteConsumo { get; set; } = null!;

    public decimal CantConsxLote { get; set; }

    public string TipoProd { get; set; } = null!;

    public short Nivel { get; set; }
}
