using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPedidosDespacho
{
    public int DocEntry { get; set; }

    public int PedSap { get; set; }

    public string? Cliente { get; set; }

    public string? DirDespacho { get; set; }

    public DateTime? FecDocto { get; set; }

    public DateTime? FecDespacho { get; set; }

    public string IndFacturado { get; set; } = null!;

    public string? Indvuelta { get; set; }

    public decimal? PesoTotal { get; set; }

    public decimal? PesoPendiente { get; set; }
}
