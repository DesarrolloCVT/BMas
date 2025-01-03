using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenCamionesFecha
{
    public string Camion { get; set; } = null!;

    public DateTime FechaEntrega { get; set; }

    public int? CantPedidos { get; set; }

    public int? CantPallets { get; set; }

    public int? PesoTotal { get; set; }
}
