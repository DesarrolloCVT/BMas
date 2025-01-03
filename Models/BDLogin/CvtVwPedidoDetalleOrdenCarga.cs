using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPedidoDetalleOrdenCarga
{
    public int NumPedido { get; set; }

    public int DocNum { get; set; }

    public DateTime? Fentrega { get; set; }

    public string? TipoPallet { get; set; }

    public string CodProducto { get; set; } = null!;

    public decimal CantPedidoSap { get; set; }

    public decimal CantidadPallets { get; set; }

    public decimal PesoTotalPallets { get; set; }

    public string? TipoSoportante { get; set; }
}
