using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTiempobajadapedidopbi
{
    public int? OrderUNumDocSap { get; set; }

    public DateTime? UltimoPosicionado { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public DateTime? PrimeroPosicionado { get; set; }

    public int? CantidadPallets { get; set; }

    public int? TiempoMinutos { get; set; }

    public int? TiempoPorPallet { get; set; }
}
