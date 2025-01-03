using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPedidoOrdenCarga
{
    public int NumPedido { get; set; }

    public int DocNum { get; set; }

    public DateTime? Fentrega { get; set; }

    public string? Cliente { get; set; }

    public string? DirDespacho { get; set; }

    public decimal? CantidadPallets { get; set; }

    public decimal? PesoTotalPallets { get; set; }

    public int Asignado { get; set; }

    public string? NumAtCard { get; set; }
}
